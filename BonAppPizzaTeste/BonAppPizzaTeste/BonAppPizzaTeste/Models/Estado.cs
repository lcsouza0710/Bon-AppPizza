using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Estado
    {
        public long CodEstado { get; set; }
        public virtual Pais Pais { get; set; }
        public string NomeEstado { get; set; }
        public string SiglaEstado { get; set; }

        public Estado (long codEstado, string nomeEstado, string siglaEstado, Pais pais)
        {
            this.CodEstado = codEstado;
            this.NomeEstado = nomeEstado;
            this.SiglaEstado = siglaEstado;
            this.Pais = pais;
        }
    }
}
