public class Cartao
{
	[Key]
	public int CodBandeira {get; set;}
	
	[ForeignKey ("CodTpCartao")]
	public virtual TpCartao TpCartao {get; set;}
	
	public string Bandeira {get; set;}
}