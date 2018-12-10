using System.Collections.Generic;

namespace Bonn_App_Pizza.Models.Entidades
{
    public class Pais
    {
        public int IdPais { get; set; }
        public string NmPais { get; set; }
        public string SgPais { get; set; }
        public ICollection<Estado> Estados { get; set; }
    }
}