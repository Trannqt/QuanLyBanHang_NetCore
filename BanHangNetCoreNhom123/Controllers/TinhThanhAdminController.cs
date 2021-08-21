using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanHangNetCoreNhom123.Models;

namespace BanHangNetCoreNhom123.Controllers
{
    public class TinhThanhAdminController : BaseController
    {
        private readonly MyDbContext _context;

        public TinhThanhAdminController(MyDbContext context)
        {
            _context = context;
        }

        // GET: TinhThanhAdmin
        public async Task<IActionResult> Index()
        {
            ViewBag.List = _context.TinhThanh.ToList();
            return View(await _context.TinhThanh.ToListAsync());
        }

        // GET: TinhThanhAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhThanh = await _context.TinhThanh
                .FirstOrDefaultAsync(m => m.MaTinhThanh == id);
            if (tinhThanh == null)
            {
                return NotFound();
            }

            ViewBag.TinhThanh = tinhThanh;

            return PartialView("_resultDetails", tinhThanh);
        }

        // GET: TinhThanhAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TinhThanhAdmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaTinhThanh,TenTinhThanh")] TinhThanh tinhThanh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tinhThanh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tinhThanh);
        }

        // GET: TinhThanhAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tinhThanh = await _context.TinhThanh.FindAsync(id);
            if (tinhThanh == null)
            {
                return NotFound();
            }
            return View(tinhThanh);
        }

        // POST: TinhThanhAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaTinhThanh,TenTinhThanh")] TinhThanh tinhThanh)
        {
            if (id != tinhThanh.MaTinhThanh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tinhThanh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TinhThanhExists(tinhThanh.MaTinhThanh))
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
            return View(tinhThanh);
        }

        // GET: TinhThanhAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var tinhThanh = await _context.TinhThanh.FindAsync(id);
            _context.TinhThanh.Remove(tinhThanh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: TinhThanhAdmin/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var tinhThanh = await _context.TinhThanh.FindAsync(id);
        //    _context.TinhThanh.Remove(tinhThanh);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool TinhThanhExists(int id)
        {
            return _context.TinhThanh.Any(e => e.MaTinhThanh == id);
        }
    }
}
