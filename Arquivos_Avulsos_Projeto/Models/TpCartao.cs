public class TpCartao
{
	[Key]
	public int CodTpCartao {get; set;}
	
	public string TpCartao {get; set;}
	
	public virtual ICollection<Cartao> Cartao {get; set;}
}
