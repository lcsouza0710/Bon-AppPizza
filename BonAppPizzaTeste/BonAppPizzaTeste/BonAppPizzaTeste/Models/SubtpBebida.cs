using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class SubtpBebida
    {
        public int CodSubtpBebida { get; set; }
        public virtual TpBebida TpBebida { get; set; }
        public string SubtipoBebida { get; set; }
        public virtual ICollection<MarcaBebida> Marcas { get; set; }

        SubtpBebida()
        {

        }
    }
}
