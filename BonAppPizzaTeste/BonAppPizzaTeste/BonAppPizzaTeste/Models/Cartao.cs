using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Cartao
    {
        public int CodBandeira { get; set; }
        public virtual TpCartao TpCartao { get; set; }
        public string Bandeira { get; set; }
        public string Logotipo { get; set; }

        public Cartao()
        {

        }
    }
}
