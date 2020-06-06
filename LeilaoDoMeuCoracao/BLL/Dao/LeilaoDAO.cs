using LeilaoDoMeuCoracao.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoDoMeuCoracao.BLL.Dao
{
    public class LeilaoDAO
    {
        private readonly LeilaoContext _context;

        public LeilaoDAO()
        {
            _context = new LeilaoContext();
        }

        public LeilaoContext GetContext()
        {
            return _context;
        }

        public async Task<List<Leilao>> ListAll()
        {
            return await _context.Leiloes.ToListAsync();
        }

        public async Task<Leilao> DetailsById(int? id)
        {
            return await _context.Leiloes.FirstOrDefaultAsync(m => m.LeilaoId == id);
        }

        public async Task Create(Leilao leilao)
        {
            _context.Add(leilao);
            await _context.SaveChangesAsync();
        }

        public async Task<Leilao> EditById(int? id)
        {
            return await _context.Leiloes.FindAsync(id);
        }

        public async Task<Leilao> EditByIdAndObject(int id, Leilao leilao)
        {
            _context.Update(leilao);
            await _context.SaveChangesAsync();

            return leilao;
        }

        public async Task<Leilao> GetToDeleteById(int? id)
        {
            var leilao = await _context.Leiloes.FirstOrDefaultAsync(m => m.LeilaoId == id);

            return leilao;
        }

        public async Task DeleteById(int? id)
        {
            var leilao = await _context.Leiloes.FirstOrDefaultAsync(m => m.LeilaoId == id);
            _context.Leiloes.Remove(leilao);
            await _context.SaveChangesAsync();
        }

        public bool LeilaoExists(int id) => _context.Leiloes.Any(e => e.LeilaoId == id);
    }
}
