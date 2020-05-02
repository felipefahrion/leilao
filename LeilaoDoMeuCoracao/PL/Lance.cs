using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoDoMeuCoracao.PL
{
    public class Lance
    {
        public int LanceId { get; set; }
        public DateTime DataHoraLance { get; set; }
        public double Valor { get; set; }
        public bool Aceito { get; set; }
        public User User { get; set; }
        public int LeilaoId { get; set; }
        public Leilao Leilao { get; set; }
    }
}
