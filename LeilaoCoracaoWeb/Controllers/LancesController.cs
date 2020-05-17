using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeilaoDoMeuCoracao.PL;

namespace LeilaoCoracaoWeb.Controllers
{
    public class LancesController : Controller
    {
        private readonly LeilaoContext _context;

        public LancesController(LeilaoContext context)
        {
            _context = context;
        }

        // GET: Lances
        public async Task<IActionResult> Index()
        {
            var leilaoContext = _context.Lances.Include(l => l.Leilao);
            return View(await leilaoContext.ToListAsync());
        }

        // GET: Lances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lance = await _context.Lances
                .Include(l => l.Leilao)
                .FirstOrDefaultAsync(m => m.LanceId == id);
            if (lance == null)
            {
                return NotFound();
            }

            return View(lance);
        }

        // GET: Lances/Create
        public IActionResult Create()
        {
            ViewData["LeilaoId"] = new SelectList(_context.Leiloes, "LeilaoId", "LeilaoId");
            return View();
        }

        // POST: Lances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LanceId,DataHoraLance,Valor,Aceito,LeilaoId")] Lance lance)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LeilaoId"] = new SelectList(_context.Leiloes, "LeilaoId", "LeilaoId", lance.LeilaoId);
            return View(lance);
        }

        // GET: Lances/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lance = await _context.Lances.FindAsync(id);
            if (lance == null)
            {
                return NotFound();
            }
            ViewData["LeilaoId"] = new SelectList(_context.Leiloes, "LeilaoId", "LeilaoId", lance.LeilaoId);
            return View(lance);
        }

        // POST: Lances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LanceId,DataHoraLance,Valor,Aceito,LeilaoId")] Lance lance)
        {
            if (id != lance.LanceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LanceExists(lance.LanceId))
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
            ViewData["LeilaoId"] = new SelectList(_context.Leiloes, "LeilaoId", "LeilaoId", lance.LeilaoId);
            return View(lance);
        }

        // GET: Lances/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lance = await _context.Lances
                .Include(l => l.Leilao)
                .FirstOrDefaultAsync(m => m.LanceId == id);
            if (lance == null)
            {
                return NotFound();
            }

            return View(lance);
        }

        // POST: Lances/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lance = await _context.Lances.FindAsync(id);
            _context.Lances.Remove(lance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LanceExists(int id)
        {
            return _context.Lances.Any(e => e.LanceId == id);
        }
    }
}
