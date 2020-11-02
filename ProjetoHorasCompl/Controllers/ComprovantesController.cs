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
    public class ComprovantesController : Controller
    {
        private readonly ProjetoHorasComplContext _context;

        public ComprovantesController(ProjetoHorasComplContext context)
        {
            _context = context;
        }

        // GET: Comprovantes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Comprovante.ToListAsync());
        }

        // GET: Comprovantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comprovante = await _context.Comprovante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comprovante == null)
            {
                return NotFound();
            }

            return View(comprovante);
        }

        // GET: Comprovantes/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CmpDescricao,CmpDataInicio,CmpDataFim,CmpQtdHoras")] Comprovante comprovante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comprovante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comprovante);
        }

        // GET: Comprovantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comprovante = await _context.Comprovante.FindAsync(id);
            if (comprovante == null)
            {
                return NotFound();
            }
            return View(comprovante);
        }

        // POST: Comprovantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CmpDescricao,CmpDataInicio,CmpDataFim,CmpQtdHoras")] Comprovante comprovante)
        {
            if (id != comprovante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comprovante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComprovanteExists(comprovante.Id))
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
            return View(comprovante);
        }

        // GET: Comprovantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comprovante = await _context.Comprovante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comprovante == null)
            {
                return NotFound();
            }

            return View(comprovante);
        }

        // POST: Comprovantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comprovante = await _context.Comprovante.FindAsync(id);
            _context.Comprovante.Remove(comprovante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComprovanteExists(int id)
        {
            return _context.Comprovante.Any(e => e.Id == id);
        }

        public IActionResult BuscaSimples()
        {
            return View();
        }
        public IActionResult BuscaAgrupada()
        {
            return View();
        }
    }
}
