using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class TpCartao
    {
        public int CodTpCartao { get; set; }
        public string TipoCartao { get; set; }
        public virtual ICollection<Cartao> Cartoes { get; set;}

        public TpCartao()
        {

        }
    }
}
