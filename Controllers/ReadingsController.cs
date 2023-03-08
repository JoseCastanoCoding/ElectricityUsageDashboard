using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ElectricityUsageDashboard.Data;
using ElectricityUsageDashboard.Models;

namespace ElectricityUsageDashboard.Controllers
{
    public class ReadingsController : Controller
    {
        private readonly ReadingsDbContext _context;

        public ReadingsController(ReadingsDbContext context)
        {
            _context = context;
        }

        // GET: Readings
        public async Task<IActionResult> Index()
        {
              return View(await _context.Readings.ToListAsync());
        }

        // GET: Readings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Readings == null)
            {
                return NotFound();
            }

            var reading = await _context.Readings
                .FirstOrDefaultAsync(entity => entity.ReadingId == id);
            if (reading == null)
            {
                return NotFound();
            }

            return View(reading);
        }

        // GET: Readings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Readings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReadingId,ReadingDate,CurrentReading,IsBilledReading")] Reading reading)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reading);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reading);
        }

        // GET: Readings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Readings == null)
            {
                return NotFound();
            }

            var reading = await _context.Readings.FindAsync(id);
            if (reading == null)
            {
                return NotFound();
            }
            return View(reading);
        }

        // POST: Readings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReadingId,ReadingDate,CurrentReading,IsBilledReading")] Reading reading)
        {
            if (id != reading.ReadingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reading);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReadingExists(reading.ReadingId))
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
            return View(reading);
        }

        // GET: Readings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Readings == null)
            {
                return NotFound();
            }

            var reading = await _context.Readings
                .FirstOrDefaultAsync(m => m.ReadingId == id);
            if (reading == null)
            {
                return NotFound();
            }

            return View(reading);
        }

        // POST: Readings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Readings == null)
            {
                return Problem("Entity set 'ReadingsDbContext.Readings'  is null.");
            }
            var reading = await _context.Readings.FindAsync(id);
            if (reading != null)
            {
                _context.Readings.Remove(reading);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReadingExists(int id)
        {
          return _context.Readings.Any(e => e.ReadingId == id);
        }
    }
}
