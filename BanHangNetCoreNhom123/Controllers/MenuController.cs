using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHangNetCoreNhom123.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanHangNetCoreNhom123.Controllers
{
    public class MenuController : Controller
    {
        private readonly MyDbContext db;
        public MenuController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            ViewBag.ListProduct = query_thucdon.GetDataByPage(1, 6);
            var dstd = query_thucdon.GetAllData();
            ViewBag.Count = dstd.Count();
            LoaiThucDonViewModel query_loaithucdon = new LoaiThucDonViewModel(db);
            ViewBag.ListCate = query_loaithucdon.GetLoaiThucDon();

            NhaSanXuatViewModel nsx = new NhaSanXuatViewModel(db);
            ViewBag.ListNsx = nsx.GetNhaSanXuat();
            return View();
        }

        
        public IActionResult sortby(string value)
        {

            ThucDonViewModel dstd = new ThucDonViewModel(db);
            var td = dstd.GetAllData();

            if (value==("Name"))
            {
                ViewBag.ListProduct = dstd.SortByName(); 
                return PartialView("_resultSortBy", ViewBag.ListProduct);
            }
            if (value==("Price"))
            {
                ViewBag.ListProduct = td.OrderBy(p => p.Gia).Take(6);
                return PartialView("_resultSortBy", ViewBag.ListProduct);
            }
            ViewBag.ListProduct = td;
            return PartialView("_resultSortBy", ViewBag.ListProduct);
        }

        public IActionResult SearchDetail(string key)
        {
            //ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            //ViewBag.LoaiThucDon = query_thucdon.GetAllData().Where(p=>p.TenThucDon.Contains(key));

            var r = from td in db.ThucDon
                    join ltd in db.LoaiThucDon on td.MaLoai equals ltd.MaLoai
                    orderby td.MaThucDon descending
                    select new ThucDonViewModel()
                    {
                        MaThucDon = td.MaThucDon,
                        TenThucDon = td.TenThucDon,
                        HinhAnh = td.HinhAnh,
                        TenLoai = ltd.TenLoai,
                        MaLoai = td.MaLoai,
                        Gia = td.Gia,
                        KhuyenMai = td.KhuyenMai,
                        GetGiaKhuyenMai = td.GiaKhuyenMai,
                        MoTa = td.MoTa
                    };

            ViewBag.ListProduct = r.Where(p => p.TenThucDon.Contains(key)).ToList();
            return PartialView("_resultInInfo", ViewBag.ListProduct);
        }
        
        public IActionResult Search(string key)
        {
            //ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            //ViewBag.LoaiThucDon = query_thucdon.GetAllData().Where(p=>p.TenThucDon.Contains(key));

            var r = from td in db.ThucDon
                    join ltd in db.LoaiThucDon on td.MaLoai equals ltd.MaLoai
                    select new ThucDonViewModel()
                    {
                        MaThucDon = td.MaThucDon,
                        TenThucDon = td.TenThucDon,
                        HinhAnh = td.HinhAnh,
                        TenLoai = ltd.TenLoai,
                        MaLoai = td.MaLoai,
                        Gia = td.Gia,
                        KhuyenMai = td.KhuyenMai,
                        GetGiaKhuyenMai = td.GiaKhuyenMai,
                        MoTa = td.MoTa
                    };
            
            ViewBag.ListProduct = r.Where(p=>p.TenThucDon.Contains(key)).ToList();
            return PartialView("_resultCategory", ViewBag.ListProduct);
        }


        public IActionResult getAllCate()
        {
            //return Content("Oke");
            LoaiThucDonViewModel query_lthucdon = new LoaiThucDonViewModel(db);
            ViewBag.LoaiThucDon = query_lthucdon.GetLoaiThucDon();
            return PartialView("_result", ViewBag.LoaiThucDon);
        }

        public IActionResult GetProductByPageWithPage(int page,int status)
        {
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            if (status == 1)
            {
                page = page + 1;
            }
            else
            {
                page = page - 1;
            }
            ViewBag.ListProduct = query_thucdon.GetDataByPage(page,6);
            return PartialView("_resultCategory", ViewBag.ListProduct);
        }


        public IActionResult getProductsByBrand(string brandId,int page)
        {
            //return Content("Oke");
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            ViewBag.ListProduct = query_thucdon.GetAllDataByBrand(brandId,page);
            return PartialView("_resultCategory", ViewBag.ListProduct);
        }
        
        public IActionResult getProductsByCate(string categoryID, int page)
        {
            //return Content("Oke");
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            ViewBag.ListProduct = query_thucdon.GetAllDataByCate(categoryID,page);

            return PartialView("_resultCategory", ViewBag.ListProduct);
        }

        public IActionResult getProductsByCateNavbar(string id)
        {
            ThucDonViewModel query_thucdon = new ThucDonViewModel(db);
            ViewBag.ListProduct = query_thucdon.GetAllDataByCate(id).Take(6);

            LoaiThucDonViewModel query_loaithucdon = new LoaiThucDonViewModel(db);
            ViewBag.ListCate = query_loaithucdon.GetLoaiThucDon();

            NhaSanXuatViewModel nsx = new NhaSanXuatViewModel(db);
            ViewBag.ListNsx = nsx.GetNhaSanXuat();
            return View();
            //return RedirectToAction("Index",)
        }
    }
}