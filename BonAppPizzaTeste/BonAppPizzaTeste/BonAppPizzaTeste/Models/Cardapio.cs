using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Cardapio
    {
        public int CodCardapio { get; set; }
        public virtual Estabelecimento Estabelecimento { get; set; }
        public virtual ICollection<Pizza> Pizzas { get; set; }
        public virtual ICollection<Bebida> Bebidas { get; set; }

        public Cardapio()
        {

        }
    }
}
