using LeilaoDoMeuCoracao.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoDoMeuCoracao.BLL.Dao
{
    public class ItemDAO
    {
        private readonly LeilaoContext _context;

        public ItemDAO()
        {
            _context = new LeilaoContext();
        }

        public LeilaoContext GetContext()
        {
            return _context;
        }

        public async Task<List<Item>> ListAll() => await _context.Itens.ToListAsync();

        public async Task<Item> DetailsById(int? id)
        {
            return await _context.Itens.FirstOrDefaultAsync(m => m.ItemId == id);
        }

        public async Task Create(Item item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Item> EditById(int? id)
        {
            return await _context.Itens.FindAsync(id);
        }

        public async Task<Item> EditByIdAndObject(int id, Item item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();

            return item;
        }

        public async Task<Item> GetToDeleteById(int? id)
        {
            var item = await _context.Itens.FirstOrDefaultAsync(m => m.ItemId == id);

            return item;
        }

        public async Task DeleteById(int? id)
        {
            var item = await _context.Itens.FirstOrDefaultAsync(m => m.ItemId == id);
            _context.Itens.Remove(item);
            await _context.SaveChangesAsync();
        }
        public bool ItemExists(int id)
        {
            return _context.Itens.Any(e => e.ItemId == id);
        }
    }
}
