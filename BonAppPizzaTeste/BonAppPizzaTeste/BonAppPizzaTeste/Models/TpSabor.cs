using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class TpSabor
    {
        public int CodTpSabor { get; set; }
        public enum TipoSabor
        {
            Doce,
            Salgado
        }

        public TpSabor()
        {

        }
    }
}
