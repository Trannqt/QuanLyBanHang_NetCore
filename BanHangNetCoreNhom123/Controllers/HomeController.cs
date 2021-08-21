using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BanHangNetCoreNhom123.Models;

namespace BanHangNetCoreNhom123.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext db;
        public HomeController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var dstd = (from td in db.ThucDon
                       join ltd in db.LoaiThucDon
                       on td.MaLoai equals ltd.MaLoai
                       join nsx in db.NhaSanXuat
                       on td.MaNSX equals nsx.MaNSX
                       orderby td.LuotMua descending
                       select new ThucDonViewModel
                       {
                           MaThucDon = td.MaThucDon,
                           TenThucDon = td.TenThucDon,
                           HinhAnh = td.HinhAnh,
                           TenLoai = ltd.TenLoai,
                           MaLoai = td.MaLoai,
                           Gia = td.Gia,
                           KhuyenMai = td.KhuyenMai,
                           GetGiaKhuyenMai = td.GiaKhuyenMai,
                           MoTa = td.MoTa,
                           Description = td.Description,
                           TenNSX = nsx.TenNSX,
                           MaNSX = nsx.MaNSX
                       }).Take(4);

            ThucDonViewModel dsThucDon = new ThucDonViewModel(db);
            //ViewBag.ListProduct = dsThucDon.GetAllData().OrderByDescending(x=>x.LuotMua).Take(4);
            ViewBag.ListProduct = dstd;
            ViewBag.ListDiscount = dsThucDon.GetAllData().Where(x => x.KhuyenMai != 0).Take(4);
            ViewBag.Banner = db.Banner.ToList();
            //ViewBag.LuotTruyCap = db.TaiKhoan.Where(p => p.DangHoatDong == 1).ToList().Count();
            return View();
        }
        public IActionResult SLOnline()
        {
            ViewBag.Soluongonline = db.TaiKhoan.Where(p => p.DangHoatDong == 1).ToList().Count();
            return PartialView("_resultOnline", ViewBag.Soluongonline);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
