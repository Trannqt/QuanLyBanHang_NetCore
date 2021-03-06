using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BanHangNetCoreNhom123.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BanHangNetCoreNhom123.Controllers
{
    public class LoginController : Controller
    {
        private readonly MyDbContext db;
        public LoginController(MyDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(string username, string password)
        {
            var tk = db.TaiKhoan.SingleOrDefault(x => x.TenTaiKhoan == username && x.MatKhau == password);
            if (tk == null)
            {
                ViewBag.NotExist = false;
                return View("Index");
            }
            else
            {
                HttpContext.Session.SetString("USERNAME_SESSION", tk.TenTaiKhoan.ToString());
                HttpContext.Session.SetInt32("CREDENTITY_SESSION", Convert.ToInt32(tk.MaPhanQuyen));
                HttpContext.Session.SetString("ID_SESSION", tk.MaTaiKhoan.ToString());
                HttpContext.Session.SetString("AVATAR_SESSION", tk.AnhDaiDien.ToString());
                HttpContext.Session.SetString("EMAIL_SESSION", tk.Email.ToString());


                var taikhoan = db.TaiKhoan.Where(p => p.MaTaiKhoan == tk.MaTaiKhoan).SingleOrDefault();
                taikhoan.DangHoatDong = 1;
                db.Update(taikhoan);
                db.SaveChanges();
                //CommonConstant.ACCOUNT_SESSION = HttpContext.Session.GetString("USERNAME_SESSION");
                //CommonConstant.CREDENTITY = HttpContext.Session.GetString("CREDENTITY_SESSION");
                //CommonConstant.ACCID_SESSION = HttpContext.Session.GetString("ACCID_SESSION");
                if (Convert.ToInt32(tk.MaPhanQuyen) == 2)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "DashBoard");
                }
            }
        }

        public IActionResult SignUp()
        {
            //ViewBag.City = from tt in db.TinhThanh select tt;
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(string username, string password,
                                    string email, IFormFile avatar)
        {
            var check_exist = db.TaiKhoan.SingleOrDefault(x => x.TenTaiKhoan == username);
            if (check_exist == null)
            {
                TaiKhoan newTk = new TaiKhoan
                {
                    TenTaiKhoan = username,
                    MatKhau = password,
                    Email = email,
                    MaPhanQuyen = "2"
                };
                if (avatar != null)
                {
                    string path_to_image = "wwwroot/user/images/khachhang/" + avatar.FileName;
                    using (var stream = new FileStream(path_to_image, FileMode.Create))
                    {
                        avatar.CopyTo(stream);
                    }
                    newTk.AnhDaiDien = avatar.FileName;
                }
                else
                {
                    newTk.AnhDaiDien = "none-avatar.jpg";
                }
                db.TaiKhoan.Add(newTk);
                db.SaveChanges();
                ViewBag.RegisterSucess = true;
                return View("Index");
            }
            else
            {
                ViewBag.AccExist = false;
                return View("SignUp");
            }

        }

        public IActionResult SignOut()
        {
            var taikhoan = db.TaiKhoan.Where(p => p.MaTaiKhoan == Convert.ToInt32(HttpContext.Session.GetString("ID_SESSION"))).SingleOrDefault();
            taikhoan.DangHoatDong = 0;
            db.Update(taikhoan);
            db.SaveChanges();
            HttpContext.Session.Clear();
            //CommonConstant.ACCOUNT_SESSION = HttpContext.Session.GetString("USERNAME_SESSION");
            //CommonConstant.CREDENTITY = HttpContext.Session.GetString("CREDENTITY_SESSION");
            return RedirectToAction("Index", "Home");
        }

    }
}