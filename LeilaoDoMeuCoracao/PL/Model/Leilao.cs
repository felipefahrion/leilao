using LeilaoDoMeuCoracao.PL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LeilaoDoMeuCoracao.PL
{
    public class Leilao
    {
        public int LeilaoId { get; set; }
        public User UserCriador { get; set; }
        [Display(Name = "Data início de lances")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data máxima de lances")]
        public DateTime DataMaxLances { get; set; }
        public double Valor { get; set; }
        [Display(Name = "Status do leião")]
        public StatusLeilaoEnum StatusLeilaoEnum { get; set; }
        [Display(Name = "Tipo do leilão")]
        public TipoLeilaoEnum TipoLeilaoEnum { get; set; }
        public ICollection<Item> Itens { get; set; }
        public ICollection<Lance> Lances { get; set; }
    }
}
