using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Estabelecimento
    {
        public long CodPizzaria { get; set; }
        public string NomeDivulgacao { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Proprietario { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
