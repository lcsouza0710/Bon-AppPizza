using System;
using System.Collections.Generic;
using System.Text;

namespace BonAppPizzaTeste.Models
{
    public class ServicosPizzaria
    {
        public int CodListaServicos { get; set; }
        public virtual Estabelecimento Estabelecimento { get; set; } 
        public virtual Estacionamento Estacionamento { get; set; }
        public bool Rodizio { get; set;}
        public int MinRodizio { get; set; }
        public float PrecoRodizio { get; set; }
        public virtual PromoRodizio PromoRodizio { get; set; }
        public virtual ICollection<Cartao> Carotes { get; set; }
        public bool WiFi { get; set; }
        public bool SalaoJogos { get; set; }
        public bool EspacoKids { get; set; }
        public bool Delivery { get; set; }
        public bool LaCarte { get; set; }
        public bool Jukebbox { get; set; }
        public bool Karaoke { get; set; }
        public bool Reserva { get; set; }
        public bool SalaoFechado { get; set; }

        public ServicosPizzaria()
        {

        }

    }
}
