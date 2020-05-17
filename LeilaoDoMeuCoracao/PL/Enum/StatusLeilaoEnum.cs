using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LeilaoDoMeuCoracao.PL.Enum
{
    public enum StatusLeilaoEnum
    {
        [Display(Name = "Fechado")]
        FECHADO,
        [Display(Name = "Aberto")]
        ABERTO
    }
}
