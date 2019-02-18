using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste
{
    public class Estabelecimento
    {
        public string NomeEstabel { get; set; } = "Bon'App Pizza Teste";
        public string Endereco { get; set; } = "Rua Amador Bueno, 389/491";
        public string Bairro { get; set; } = "Santo Amaro";
        public string Cidade { get; set; } = "São Paulo";
        public string Estado { get; set; } = "SP";

        public Estabelecimento()
        {

        }
    }
}
