using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanHangNetCoreNhom123.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BanHangNetCoreNhom123.Controllers
{
    public class TaiKhoanAdminController : BaseController
    {
        private readonly MyDbContext _context;

        public TaiKhoanAdminController(MyDbContext context)
        {
            _context = context;
        }

        // GET: TaiKhoanAdmin
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.TaiKhoan.Include(t => t.MaPhanQuyenNavigation);
            ViewBag.List = myDbContext;
            return View(await myDbContext.ToListAsync());
        }

        // GET: TaiKhoanAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan
                .Include(t => t.MaPhanQuyenNavigation)
                .FirstOrDefaultAsync(m => m.MaTaiKhoan == id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            ViewBag.TaiKhoan = taiKhoan;
            //ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen", taiKhoan.MaPhanQuyen);
            return PartialView("_resultEdit", ViewBag.TaiKhoan);
        }

        // GET: TaiKhoanAdmin/Create
        public IActionResult Create()
        {
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "QuyenHan");
            return View();
        }

        // POST: TaiKhoanAdmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTaiKhoan,TenTaiKhoan,MatKhau,MaPhanQuyen,Email,AnhDaiDien,DangHoatDong")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taiKhoan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // GET: TaiKhoanAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoan == null)
            {
                return NotFound();
            }
            ViewBag.TaiKhoan = taiKhoan;
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // POST: TaiKhoanAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTaiKhoan,TenTaiKhoan,MatKhau,MaPhanQuyen,Email,DangHoatDong")] TaiKhoan taiKhoan, IFormFile avatar)
        {
            
            if (id != taiKhoan.MaTaiKhoan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (avatar != null)
                    {
                        string path_to_image = "wwwroot/user/images/khachhang/" + avatar.FileName;
                        using (var stream = new FileStream(path_to_image, FileMode.Create))
                        {
                            avatar.CopyTo(stream);
                        }
                        taiKhoan.AnhDaiDien = avatar.FileName;
                    }
                    else
                    {
                        taiKhoan.AnhDaiDien = "none-avatar.jpg";
                        //return Content("oke" + avatar.FileName);
                    }

                    _context.Update(taiKhoan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TaiKhoanExists(taiKhoan.MaTaiKhoan))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaPhanQuyen"] = new SelectList(_context.PhanQuyen, "MaPhanQuyen", "MaPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // GET: TaiKhoanAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            _context.TaiKhoan.Remove(taiKhoan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: TaiKhoanAdmin/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var taiKhoan = await _context.TaiKhoan.FindAsync(id);
        //    _context.TaiKhoan.Remove(taiKhoan);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool TaiKhoanExists(int id)
        {
            return _context.TaiKhoan.Any(e => e.MaTaiKhoan == id);
        }
    }
}
