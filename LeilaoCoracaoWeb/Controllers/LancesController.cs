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
    public class LancesController : Controller
    {
        private readonly LanceFacade lanceFacade;

        public LancesController()
        {
            lanceFacade = new LanceFacade();
        }

        // GET: Lances
        public async Task<IActionResult> Index() => View(await lanceFacade.ListAll());

        // GET: Lances/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lance = await lanceFacade.DetailsById(id);

            if (lance == null)
            {
                return NotFound();
            }

            return View(lance);
        }

        // GET: Lances/Create
        public IActionResult Create()
        {
            ViewData["LeilaoId"] = new SelectList(lanceFacade.GetLeilaoContext().Leiloes, "LeilaoId", "LeilaoId");
            return View();
        }

        // POST: Lances/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LanceId,DataHoraLance,Valor,Aceito,LeilaoId")] Lance lance)
        {
            if (ModelState.IsValid)
            {
                await lanceFacade.Create(lance);

                return RedirectToAction(nameof(Index));
            }
            ViewData["LeilaoId"] = new SelectList(lanceFacade.GetLeilaoContext().Leiloes, "LeilaoId", "LeilaoId", lance.LeilaoId);

            return View(lance);
        }
    }
}
