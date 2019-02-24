using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class MarcaBebida
    {
        public int CodMarcaBebida { get; set; }
        public virtual SubtpBebida SubtpBebida { get; set; }
        public string Marca { get; set; }
        public bool Diet { get; set; }
        public bool EdicLtda { get; set; }
        public virtual ICollection<Bebida> Bebidas { get; set; }

        public MarcaBebida()
        {

        }
    }
}
