using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BanHangNetCoreNhom123.Models;
using Microsoft.AspNetCore.Http.Internal;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace BanHangNetCoreNhom123.Controllers
{
    public class BannerAdminController : BaseController
    {
        private readonly MyDbContext _context;

        public BannerAdminController(MyDbContext context)
        {
            _context = context;
        }

        // GET: BannerAdmin
        public async Task<IActionResult> Index()
        {
            ViewBag.List = _context.Banner.ToList();
            return View(await _context.Banner.ToListAsync());
        }

        // GET: BannerAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banner = await _context.Banner
                .FirstOrDefaultAsync(m => m.MaBanner == id);
            if (banner == null)
            {
                return NotFound();
            }
            ViewBag.Banner = banner;

            return PartialView("_resultDetails", banner);
            //return View(banner);
        }

        // GET: BannerAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BannerAdmin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(string tieude, string noidung, IFormFile avatar)
        {

            Banner newBanner = new Banner
            {
                TieuDe = tieude,
                NoiDung = noidung
            };
            if (avatar != null)
            {
                string path_to_image = "wwwroot/user/images/" + avatar.FileName;
                using (var stream = new FileStream(path_to_image, FileMode.Create))
                {
                    avatar.CopyTo(stream);
                }
                newBanner.UrlBanner = avatar.FileName;
            }
            else
            {
                newBanner.UrlBanner = "none-avatar.jpg";
            }
            _context.Banner.Add(newBanner);
            await _context.SaveChangesAsync();
            //ViewBag.RegisterSucess = true;
            return RedirectToAction("Index", "BannerAdmin");
        }

        // GET: BannerAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var banner = await _context.Banner.FindAsync(id);
            if (banner == null)
            {
                return NotFound();
            }
            return View(banner);
        }

        // POST: BannerAdmin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaBanner,UrlBanner,TieuDe,NoiDung")] Banner banner)
        {
            if (id != banner.MaBanner)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(banner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BannerExists(banner.MaBanner))
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
            return View(banner);
        }

        // GET: BannerAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var banner = await _context.Banner.FindAsync(id);
            _context.Banner.Remove(banner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: BannerAdmin/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var banner = await _context.Banner.FindAsync(id);
        //    _context.Banner.Remove(banner);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool BannerExists(int id)
        {
            return _context.Banner.Any(e => e.MaBanner == id);
        }
    }
}
