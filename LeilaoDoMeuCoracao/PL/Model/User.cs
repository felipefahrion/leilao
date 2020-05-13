using System;
using System.Collections.Generic;
using System.Text;

namespace LeilaoDoMeuCoracao.PL
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public ICollection<Lance> Lances { get; set; }
        public ICollection<Leilao> Leiloes { get; set; }
    }
}
