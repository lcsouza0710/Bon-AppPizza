public class ServicosPizzaria
{
	[Key]
	public int CodListaServicos {get; set;}
	
	[ForeignKey ("CodPizzaria")]
	public virtual Pizzaria Pizzaria {get; set;}
	
	[ForeignKey ("CodDescricao")]
	public virtual EstacionPizzaria Estacionamento {get; set;}
	
	public bool Rodizio {get; set;}
	public int MinRodizio {get; set;}
	public float PrecoRodizio {get; set;}
	
	[ForeignKey ("CodPromo")]
	public virtual PromoRodizio PromoRodizio {get; set;}
	
	public virtual ICollection<Cartao> Cartoes {get; set;}
	public bool WiFi {get; set;}
	public bool SalaoJogos {get; set;}
	public bool EspacoKids {get; set;}
	public bool Delivery {get; set;}
	public bool LaCarte {get; set;}
	public bool Jukebox {get; set;}
	public bool Karaoke {get; set;}
	public bool Reserva {get; set;}
	public bool SalaoFechado {get; set;}

}