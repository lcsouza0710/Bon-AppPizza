using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class TpLogradouro
    {
        public int CodTpLogradouro { get; set; }
        public string TipoLogradouro { get; set; }

        public TpLogradouro(int codTpLogradouro, string tipoLogradouro)
        {
            this.CodTpLogradouro = codTpLogradouro;
            this.TipoLogradouro = tipoLogradouro;
        }
    }
}
