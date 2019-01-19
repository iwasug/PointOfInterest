using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PointOfInterest.Models;

namespace PointOfInterest.Controllers
{
    public class RumahController : Controller
    {
        private readonly Db _context;

        public RumahController()
        {
            _context = new Db();
        }

        // GET: Rumahs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rumah.ToListAsync());
        }

        // GET: Rumahs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rumah = await _context.Rumah
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rumah == null)
            {
                return NotFound();
            }

            return View(rumah);
        }

        // GET: Rumahs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rumahs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nama,Type,Alamat,Latitude,Longitude,Create,Update")] Rumah rumah)
        {
            if (ModelState.IsValid)
            {
                rumah.Id = Guid.NewGuid();
                _context.Add(rumah);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rumah);
        }

        // GET: Rumahs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rumah = await _context.Rumah.FindAsync(id);
            if (rumah == null)
            {
                return NotFound();
            }
            return View(rumah);
        }

        // POST: Rumahs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Nama,Type,Alamat,Latitude,Longitude,Create,Update")] Rumah rumah)
        {
            if (id != rumah.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    rumah.Update = DateTime.Now;
                    _context.Update(rumah);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RumahExists(rumah.Id))
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
            return View(rumah);
        }

        // GET: Rumahs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rumah = await _context.Rumah
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rumah == null)
            {
                return NotFound();
            }

            return View(rumah);
        }

        // POST: Rumahs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var rumah = await _context.Rumah.FindAsync(id);
            _context.Rumah.Remove(rumah);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RumahExists(Guid id)
        {
            return _context.Rumah.Any(e => e.Id == id);
        }

        public async Task<IActionResult> GetLocations()
        {
            var locations = new List<Locations>();
            var r = await _context.Rumah.ToListAsync();
            foreach(var each in r)
            {
                locations.Add(new Locations(double.Parse(each.Latitude), double.Parse(each.Longitude), each.Nama));
            }
            return Json(locations);
        }
    }
}
