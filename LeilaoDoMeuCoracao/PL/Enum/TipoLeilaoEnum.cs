using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeilaoDoMeuCoracao.PL.Enum
{
    public enum TipoLeilaoEnum
    {
        [Display(Name = "Demanda")]
        DEMANDA = 0,

        [Display(Name = "Oferta")]
        OFERTA = 1
    }
}
