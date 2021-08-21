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
    public class NhaSanXuatAdminController : BaseController
    {
        private readonly MyDbContext _context;

        public NhaSanXuatAdminController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NhaSanXuatAdmin
        public async Task<IActionResult> Index()
        {
            ViewBag.List = _context.NhaSanXuat.ToList();
            return View(await _context.NhaSanXuat.ToListAsync());
        }

        // GET: NhaSanXuatAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaSanXuat = await _context.NhaSanXuat
                .FirstOrDefaultAsync(m => m.MaNSX == id);
            if (nhaSanXuat == null)
            {
                return NotFound();
            }
            ViewBag.NhaSanXuat = nhaSanXuat;

            return PartialView("_resultDetails",nhaSanXuat);
        }

        // GET: NhaSanXuatAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhaSanXuatAdmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaNSX,TenNSX")] NhaSanXuat nhaSanXuat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhaSanXuat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhaSanXuat);
        }

        // GET: NhaSanXuatAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhaSanXuat = await _context.NhaSanXuat.FindAsync(id);
            if (nhaSanXuat == null)
            {
                return NotFound();
            }
            return View(nhaSanXuat);
        }

        // POST: NhaSanXuatAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaNSX,TenNSX")] NhaSanXuat nhaSanXuat)
        {
            if (id != nhaSanXuat.MaNSX)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhaSanXuat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhaSanXuatExists(nhaSanXuat.MaNSX))
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
            return View(nhaSanXuat);
        }

        // GET: NhaSanXuatAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                var nhaSanXuat = await _context.NhaSanXuat.FindAsync(id);
                _context.NhaSanXuat.Remove(nhaSanXuat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
            
        }

        // POST: NhaSanXuatAdmin/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var nhaSanXuat = await _context.NhaSanXuat.FindAsync(id);
        //    _context.NhaSanXuat.Remove(nhaSanXuat);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool NhaSanXuatExists(int id)
        {
            return _context.NhaSanXuat.Any(e => e.MaNSX == id);
        }
    }
}
