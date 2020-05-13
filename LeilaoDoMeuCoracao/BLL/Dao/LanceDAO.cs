using LeilaoDoMeuCoracao.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoDoMeuCoracao.BLL.Dao
{
    class LanceDAO
    {
        private readonly LeilaoContext _context;

        public LanceDAO()
        {
            _context = new LeilaoContext();
        }

        public LeilaoContext GetContext()
        {
            return _context;
        }

        public async Task<List<Lance>> ListAll() => await _context.Lances.ToListAsync();

        public async Task<Lance> DetailsById(int? id)
        {
            return await _context.Lances.FirstOrDefaultAsync(m => m.LanceId == id);
        }

        public async Task Create(Lance lance)
        {
            _context.Add(lance);
            await _context.SaveChangesAsync();
        }
    }
}
