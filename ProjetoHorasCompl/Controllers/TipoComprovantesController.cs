using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoHorasCompl.Data;
using ProjetoHorasCompl.Models;

namespace ProjetoHorasCompl.Controllers
{
    public class TipoComprovantesController : Controller
    {
        private readonly ProjetoHorasComplContext _context;

        public TipoComprovantesController(ProjetoHorasComplContext context)
        {
            _context = context;
        }

        // GET: TipoComprovantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoComprovante.ToListAsync());
        }

        // GET: TipoComprovantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoComprovante = await _context.TipoComprovante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoComprovante == null)
            {
                return NotFound();
            }

            return View(tipoComprovante);
        }

        // GET: TipoComprovantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoComprovantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipNome")] TipoComprovante tipoComprovante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoComprovante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoComprovante);
        }

        // GET: TipoComprovantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoComprovante = await _context.TipoComprovante.FindAsync(id);
            if (tipoComprovante == null)
            {
                return NotFound();
            }
            return View(tipoComprovante);
        }

        // POST: TipoComprovantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipNome")] TipoComprovante tipoComprovante)
        {
            if (id != tipoComprovante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoComprovante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoComprovanteExists(tipoComprovante.Id))
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
            return View(tipoComprovante);
        }

        // GET: TipoComprovantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoComprovante = await _context.TipoComprovante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoComprovante == null)
            {
                return NotFound();
            }

            return View(tipoComprovante);
        }

        // POST: TipoComprovantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoComprovante = await _context.TipoComprovante.FindAsync(id);
            _context.TipoComprovante.Remove(tipoComprovante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoComprovanteExists(int id)
        {
            return _context.TipoComprovante.Any(e => e.Id == id);
        }
    }
}
