using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeilaoDoMeuCoracao.PL;
using LeilaoDoMeuCoracao.BLL.Facade;

namespace LeilaoCoracaoWeb.Controllers
{
    public class LeilaosController : Controller
    {
        private readonly LeilaoFacade leilaoFacade;

        public LeilaosController()
        {
            leilaoFacade = new LeilaoFacade();
        }

        // GET: Leilaos
        public async Task<IActionResult> Index() => View(await leilaoFacade.ListAll());

        // GET: Leilaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leilao = await leilaoFacade.DetailsById(id);

            if (leilao == null)
            {
                return NotFound();
            }

            return View(leilao);
        }

        // GET: Leilaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Leilaos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LeilaoId,DataInicio,DataMaxLances,Valor,StatusLeilaoEnum")] Leilao leilao)
        {
            if (ModelState.IsValid)
            {
                await leilaoFacade.Create(leilao);

                return RedirectToAction(nameof(Index));
            }
            return View(leilao);
        }

        // GET: Leilaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leilao = await leilaoFacade.EditById(id);

            if (leilao == null)
            {
                return NotFound();
            }
            return View(leilao);
        }

        // POST: Leilaos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LeilaoId,DataInicio,DataMaxLances,Valor,StatusLeilaoEnum")] Leilao leilao)
        {
            if (id != leilao.LeilaoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await leilaoFacade.EditByIdAndObject(id, leilao);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!leilaoFacade.LeilaoExists(leilao.LeilaoId))
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
            return View(leilao);
        }

        // GET: Leilaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leilao = await leilaoFacade.DetailsById(id);

            if (leilao == null)
            {
                return NotFound();
            }

            return View(leilao);
        }

        // POST: Leilaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leilaoFacade.DeleteById(id);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeterminarXubrilhos(int Id)
        {
            return View(await leilaoFacade.DeterminarXubrilhos(Id));
        }
    }
}
