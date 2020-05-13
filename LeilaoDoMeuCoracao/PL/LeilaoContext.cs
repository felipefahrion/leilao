using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoDoMeuCoracao.PL
{
    public class LeilaoContext : DbContext
    {
        public LeilaoContext(DbContextOptions<LeilaoContext> opt) : base(opt) { }
        public LeilaoContext() { }
        public DbSet<Item> Itens { get; set; }
        public DbSet<Lance> Lances { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Leilao> Leiloes { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBLeilao;Trusted_Connection=True;");
        }   
    }
}
