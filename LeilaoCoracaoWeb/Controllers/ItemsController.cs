using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeilaoDoMeuCoracao.PL;
using LeilaoDoMeuCoracao.BLL.Facade;

namespace LeilaoCoracaoWeb.Controllers
{
    public class ItemsController : Controller
    {
        private ItemFacade itemFacade;

        public ItemsController()
        {
            itemFacade = new ItemFacade();
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            return View(await itemFacade.ListAll());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await itemFacade.DetailsById(id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,Nome,DescricaoBreve,DescricaoCompleta,Imagem")] Item item)
        {
            if (ModelState.IsValid)
            {
                await itemFacade.Create(item);
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await itemFacade.EditById(id);

            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,Nome,DescricaoBreve,DescricaoCompleta,Imagem")] Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await itemFacade.EditByIdAndObject(id, item);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!itemFacade.ItemExists(item.ItemId))
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
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await itemFacade.DetailsById(id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await itemFacade.DeleteById(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
