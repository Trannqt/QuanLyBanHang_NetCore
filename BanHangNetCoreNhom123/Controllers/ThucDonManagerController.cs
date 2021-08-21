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
    public class ThucDonManagerController : BaseController
    {
        private readonly MyDbContext _context;

        public ThucDonManagerController(MyDbContext context)
        {
            _context = context;
        }

        // GET: ThucDonManager
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.ThucDon.Include(t => t.MaLoaiNavigation).Include(t => t.MaNSXNavigation);
            return View(await myDbContext.ToListAsync());
        }

        // GET: ThucDonManager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon
                .Include(t => t.MaLoaiNavigation)
                .Include(t => t.MaNSXNavigation)
                .FirstOrDefaultAsync(m => m.MaThucDon == id);
            if (thucDon == null)
            {
                return NotFound();
            }

            return View(thucDon);
        }

        // GET: ThucDonManager/Create
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "TenLoai");
            ViewData["MaNSX"] = new SelectList(_context.NhaSanXuat, "MaNSX", "TenNSX");
            return View();
        }

        // POST: ThucDonManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaThucDon,TenThucDon,HinhAnh,MaNSX,MaLoai,Gia,KhuyenMai,MoTa,Description,LuotXem,LuotMua")] ThucDon thucDon, IFormFile Ffile)
        {
            if (ModelState.IsValid)
            {
                string s = "";
                if (Ffile != null)
                {
                    string fileName = $"{DateTime.Now.Ticks}{Ffile.FileName}";
                    s = fileName;
                    thucDon.HinhAnh = s;
                    string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user", "images", "products", fileName);

                    using (var file = new FileStream(fullPath, FileMode.Create))
                    {
                        Ffile.CopyTo(file);
                    }
                }
                else
                {
                    thucDon.HinhAnh = "download.jpg";
                }
                _context.Add(thucDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "MaLoai", thucDon.MaLoai);
            ViewData["MaNSX"] = new SelectList(_context.NhaSanXuat, "MaNSX", "MaNSX", thucDon.MaNSX);
            return View(thucDon);
        }

        // GET: ThucDonManager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thucDon = await _context.ThucDon.FindAsync(id);
            if (thucDon == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "TenLoai", thucDon.MaLoai);
            ViewData["MaNSX"] = new SelectList(_context.NhaSanXuat, "MaNSX", "TenNSX", thucDon.MaNSX);
            return View(thucDon);
        }

        // POST: ThucDonManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaThucDon,TenThucDon,HinhAnh,MaNSX,MaLoai,Gia,KhuyenMai,MoTa,Description,LuotXem,LuotMua")] ThucDon thucDon, IFormFile Ffile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string s = "";
                    if (Ffile != null)
                    {
                        string fileName = $"{DateTime.Now.Ticks}{Ffile.FileName}";
                        s = fileName;
                        thucDon.HinhAnh = s;
                        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "user","images", "products", fileName);

                        using (var file = new FileStream(fullPath, FileMode.Create))
                        {
                            Ffile.CopyTo(file);
                        }
                    }
                    else
                    {
                        thucDon.HinhAnh = "download.jpg";
                    }
                    thucDon.MaThucDon = id;
                    _context.Update(thucDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThucDonExists(thucDon.MaThucDon))
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
            ViewData["MaLoai"] = new SelectList(_context.LoaiThucDon, "MaLoai", "TenLoai", thucDon.MaLoai);
            ViewData["MaNSX"] = new SelectList(_context.NhaSanXuat, "MaNSX", "TenNSX", thucDon.MaNSX);
            return View(thucDon);
        }

        // GET: ThucDonManager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            try
            {
                var thucDon = await _context.ThucDon.FindAsync(id);
                _context.ThucDon.Remove(thucDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                return View();
            }
        }

        //// POST: ThucDonManager/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var thucDon = await _context.ThucDon.FindAsync(id);
        //    _context.ThucDon.Remove(thucDon);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ThucDonExists(int id)
        {
            return _context.ThucDon.Any(e => e.MaThucDon == id);
        }
    }
}
