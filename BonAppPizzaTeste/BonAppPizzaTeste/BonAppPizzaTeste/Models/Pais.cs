using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class Pais
    {
public int CodPais { get; set; }
        public string NomePais { get; set; }

        public Pais()
        {

        }

        public Pais(int codPais, string nomePais)
        {
            this.CodPais= codPais;
            this.NomePais = NomePais;
        }
    }
}
