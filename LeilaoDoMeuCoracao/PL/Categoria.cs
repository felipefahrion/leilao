using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoDoMeuCoracao.PL
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
