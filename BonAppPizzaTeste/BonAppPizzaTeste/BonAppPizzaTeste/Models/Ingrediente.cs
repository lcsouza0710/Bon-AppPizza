using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Ingrediente
    {
        public int CodIngrediente { get; set; }
        public virtual GrupoIngrediente GrupoIngrediente { get; set; }
        public string NomeIngrediente { get; set; }

        public Ingrediente()
        {

        }
    }
}
