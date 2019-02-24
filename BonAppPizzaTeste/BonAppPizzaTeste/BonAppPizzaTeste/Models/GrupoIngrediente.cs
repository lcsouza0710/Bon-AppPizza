using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class GrupoIngrediente
    {
        public int CodGrupo { get; set; }
        public string Grupo { get; set; }
        public virtual ICollection<Ingrediente> Ingredientes { get; set; } 

        public GrupoIngrediente()
        {

        }
    }
}
