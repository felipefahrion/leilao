using LeilaoDoMeuCoracao.PL.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoDoMeuCoracao.PL
{
    public class Leilao
    {
        public int LeilaoId { get; set; }
        public User UserCriador { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataMaxLances { get; set; }
        public double Valor { get; set; }
        public LeilaoStrategy TipoLeilaoStrategy { get; set; }
        public StatusLeilaoEnum StatusLeilaoEnum { get; set; }
        public ICollection<Item> Itens { get; set; }
        public ICollection<Lance> Lances { get; set; }

    }
}
