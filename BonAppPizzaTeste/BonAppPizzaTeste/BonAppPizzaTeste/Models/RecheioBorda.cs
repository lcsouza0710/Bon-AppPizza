using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class RecheioBorda
    {
        public int CodRecheio { get; set; }
        public virtual TpSabor TpSabor { get; set; }
        public string Recheio { get; set; }

        public RecheioBorda()
        {

        }
    }
}
