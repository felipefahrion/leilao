using LeilaoDoMeuCoracao.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoDoMeuCoracao.BLL.Dao
{
    class CategoriaDAO
    {
        private readonly LeilaoContext _context;

        public CategoriaDAO()
        {
            _context = new LeilaoContext();
        }

        public LeilaoContext GetContext()
        {
            return _context;
        }

        public async Task<List<Categoria>> ListAll()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> DetailsById(int? id)
        {
            return await _context.Categorias.FirstOrDefaultAsync(m => m.CategoriaId == id);
        }

        public async Task Create(Categoria categoria)
        {
            _context.Add(categoria);
            await _context.SaveChangesAsync();
        }
        public async Task<Categoria> EditById(int? id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task<Categoria> EditByIdAndObject(int id, Categoria categoria)
        {
            _context.Update(categoria);
            await _context.SaveChangesAsync();

            return categoria;
        }
        public async Task<Categoria> GetToDeleteById(int? id)
        {
            var categoria = await _context.Categorias.FirstOrDefaultAsync(m => m.CategoriaId == id);

            return categoria;
        }

        public async Task DeleteById(int? id)
        {
            var categoria = await _context.Categorias.FirstOrDefaultAsync(m => m.CategoriaId == id);
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
        }
    }
}
