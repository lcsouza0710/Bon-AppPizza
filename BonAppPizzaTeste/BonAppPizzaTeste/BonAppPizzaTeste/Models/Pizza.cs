using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Pizza
    {
        public long CodPizza { get; set; }
        public virtual Cardapio Cardapio { get; set; }
        public virtual FormatoPizza FormatoPizza { get; set; }
        public virtual TpSabor TpSabor { get; set; }
        public virtual RecheioBorda RecheioBorda { get; set; }
        public virtual ICollection<Ingrediente> Ingredientes { get; set; }
        public decimal Preco { get; set; }

        public Pizza()
        {

        }
    }
}
