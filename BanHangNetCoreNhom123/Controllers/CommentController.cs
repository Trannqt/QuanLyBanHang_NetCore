using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BanHangNetCoreNhom123.Models;
using Microsoft.AspNetCore.Mvc;

namespace BanHangNetCoreNhom123.Controllers
{
    public class CommentController : Controller
    {
        private readonly MyDbContext db;
        public CommentController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult AddReview(string loiNX, string mTKhoan, string mThDon)
        {
            DanhGia dgianew = new DanhGia
            {
                MaTaiKhoan = Convert.ToInt32(mTKhoan),
                MaThucDon = Convert.ToInt32(mThDon),
                LoiNhanXet = loiNX,
                NgayDanhGia = DateTime.Now

            };
            db.DanhGia.Add(dgianew);
            db.SaveChanges();
            DanhGiaViewModel query_dg = new DanhGiaViewModel(db);
            ViewBag.ListDanhGia = query_dg.GetDanhGiaByProduct(mThDon).OrderByDescending(x => x.NgayDanhGia).Take(4);
            return PartialView("_commentresult", ViewBag.ListProduct);
        }
    }
}