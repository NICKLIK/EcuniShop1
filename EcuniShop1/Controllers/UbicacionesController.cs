using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcuniShop1.Data;
using EcuniShop1.Models;

namespace EcuniShop1.Controllers
{
    public class UbicacionesController : Controller
    {
        private readonly EcuniShop1Context _context;

        public UbicacionesController(EcuniShop1Context context)
        {
            _context = context;
        }

        // GET: Ubicaciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ubicacion.ToListAsync());
        }

        // GET: Ubicaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ubicacion = await _context.Ubicacion
                .FirstOrDefaultAsync(m => m.IdUbicacion == id);
            if (ubicacion == null)
            {
                return NotFound();
            }

            return View(ubicacion);
        }

        // GET: Ubicaciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ubicaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUbicacion,Provincia,Ciudad,DescuentoUbicacion")] Ubicacion ubicacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ubicacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ubicacion);
        }

        // GET: Ubicaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ubicacion = await _context.Ubicacion.FindAsync(id);
            if (ubicacion == null)
            {
                return NotFound();
            }
            return View(ubicacion);
        }

        // POST: Ubicaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUbicacion,Provincia,Ciudad,DescuentoUbicacion")] Ubicacion ubicacion)
        {
            if (id != ubicacion.IdUbicacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ubicacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UbicacionExists(ubicacion.IdUbicacion))
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
            return View(ubicacion);
        }

        // GET: Ubicaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ubicacion = await _context.Ubicacion
                .FirstOrDefaultAsync(m => m.IdUbicacion == id);
            if (ubicacion == null)
            {
                return NotFound();
            }

            return View(ubicacion);
        }

        // POST: Ubicaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ubicacion = await _context.Ubicacion.FindAsync(id);
            if (ubicacion != null)
            {
                _context.Ubicacion.Remove(ubicacion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UbicacionExists(int id)
        {
            return _context.Ubicacion.Any(e => e.IdUbicacion == id);
        }
    }
}
