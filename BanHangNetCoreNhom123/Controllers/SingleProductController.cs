using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHangNetCoreNhom123.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanHangNetCoreNhom123.Controllers
{
    public class SingleProductController : Controller
    {
        private readonly MyDbContext db;
        public SingleProductController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string id)
        {
            ThucDonViewModel query = new ThucDonViewModel(db);
            var td = query.GetDataById(id);

            ViewBag.ListProduct = query.GetAllData().OrderByDescending(x => x.LuotXem).Take(8);
            //tối qua còn chạy được mà, t còn ngồi chỉnh dcd giao diện

            ViewBag.CungLoai = query.GetAllDataByCate(td.MaLoai.ToString()).Take(3);
            DanhGiaViewModel query_dg = new DanhGiaViewModel(db);
            ViewBag.ListDanhGia = query_dg.GetDanhGiaByProduct(id).OrderByDescending(x => x.NgayDanhGia).Take(4);
            ViewBag.ThucDon = td;

            var thucDon = db.ThucDon.Find(Convert.ToInt32(id));
            if (thucDon.LuotXem == null)
            {
                thucDon.LuotXem = 1;
            }
            else
            {
                thucDon.LuotXem++;
            }
            
            db.Update(thucDon);
            db.SaveChanges();

            ViewBag.SoLuong = db.DanhGia.Where(p => p.MaThucDon == Convert.ToInt32(id)).Count();

            return View();
        }
    }
}