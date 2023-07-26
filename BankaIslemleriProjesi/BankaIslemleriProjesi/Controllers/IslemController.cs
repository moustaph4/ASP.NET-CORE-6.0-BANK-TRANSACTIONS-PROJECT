using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankaIslemleriProjesi.Models;

namespace BankaIslemleriProjesi.Controllers
{
    public class IslemController : Controller
    {
        private readonly IslemDbContext _context;

        public IslemController(IslemDbContext context)
        {
            _context = context;
        }

        // GET: Islem
        public async Task<IActionResult> Index()
        {
              return _context.Islems != null ? 
                          View(await _context.Islems.ToListAsync()) :
                          Problem("Entity set 'IslemDbContext.Islems'  is null.");
        }

        

        // GET: Islem/EkleYadaDuzenle
        public IActionResult EkleYadaDuzenle(int id = 0)
        {
            if (id == 0)
            {
                return View(new Islem());
            }
            else
            {
                return View(_context.Islems.Find(id));
            }
        }

        // POST: Islem/EkleYadaDuzenle
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EkleYadaDuzenle([Bind("IslemId,HesapNumarasi,MusteriAdi,BankaAdi,SWIFTCode,Tutar,Tarih")] Islem islem)
        {
            if (ModelState.IsValid)
            {
                if (islem.IslemId == 0)
                {
                    islem.Tarih = DateTime.Now;
                    _context.Add(islem);
                }
                else
                {
                    _context.Update(islem);
                }
                
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(islem);
        }

       

        // POST: Islem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Islems == null)
            {
                return Problem("Entity set 'IslemDbContext.Islems'  is null.");
            }
            var islem = await _context.Islems.FindAsync(id);
            if (islem != null)
            {
                _context.Islems.Remove(islem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
