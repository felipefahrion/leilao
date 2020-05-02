using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LeilaoDoMeuCoracao.PL
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Nome { get; set; }
        public string DescricaoBreve { get; set; }
        public String DescricaoCompleta { get; set; }
        public Categoria Categoria { get; set; }
        public string Imagem { get; set; }
        public Leilao Leilao { get; set; }
    }
}
