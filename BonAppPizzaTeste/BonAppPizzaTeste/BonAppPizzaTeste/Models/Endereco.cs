using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Endereco
    {
        public long CodEndereço { get; set; }
        public virtual TpLogradouro TpLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public virtual Municipio Municipio { get; set; }
        public string CEP { get; set; }

        public Endereco()
        {

        }
    }
}
