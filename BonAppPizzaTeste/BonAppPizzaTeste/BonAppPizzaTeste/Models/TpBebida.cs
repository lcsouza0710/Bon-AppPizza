using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class TpBebida
    {
        public int CodTpBebida { get; set; }
        public string TipoBebida { get; set; }
        public virtual ICollection<SubtpBebida> SubtpBebidas { get; set; }

        public TpBebida()
        {

        }
    }
}
