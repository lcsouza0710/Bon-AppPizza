using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Bebida
    {
        public long CodBebida { get; set; }
        public virtual SubtpBebida SubtpBebida { get; set; }
        public virtual EmbalagemBebida EmbalagemBebida { get; set; }
        public decimal Conteudo { get; set; }
        public virtual UnidMedida UnidMedida { get; set; }
        public bool DispEntrega { get; set; }
        public bool EdicLtdaEmbalagem { get; set; }

        public Bebida ()
        {

        }
    }
}
