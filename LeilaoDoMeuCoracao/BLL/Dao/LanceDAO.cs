﻿using LeilaoDoMeuCoracao.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<Lance>> ListAll()
        {
            var leilaoContext = _context.Lances.Include(l => l.Leilao);
            return await leilaoContext.ToListAsync();
        }

        public async Task<List<Lance>> FindAllById(int leilaoId)
        {
            var leilaoContext = _context.Lances.Include(l => l.Leilao).Include(l => l.User).Where(l => l.LeilaoId == leilaoId);
            return await leilaoContext.ToListAsync();
        }

        public async Task<Lance> DetailsById(int? id)
        {
            return await _context.Lances.Include(l => l.Leilao).FirstOrDefaultAsync(m => m.LanceId == id);
        }

        public async Task Create(Lance lance)
        {
            _context.Add(lance);
            await _context.SaveChangesAsync();
        }


    }
}
