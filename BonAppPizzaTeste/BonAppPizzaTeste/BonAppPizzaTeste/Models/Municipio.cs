using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Municipio
    {
        public long CodMunicipio { get; set; }
        public virtual Estado Estado { get; set; }
        public string NomeMunicipio { get; set; }

        public Municipio(long codMunicipio, string nomeMunicipio, Estado estado)
        {
            this.CodMunicipio = codMunicipio;
            this.NomeMunicipio = nomeMunicipio;
            this.Estado = estado;
        }
    }
}
