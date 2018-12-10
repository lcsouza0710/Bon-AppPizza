public class Bebida
{
	[Key]
	public long CodBebida {get; set;}
	
	[ForeignKey ("CodSubtpBebida")]
	public virtual SubtpBebida SubtpBebida {get; set;}
	
	[ForeignKey ("CodEmbalagem")]
	public virtual EmbalagemBebida EmbalagemBebida {get; set;}
	
	public float Conteudo {get; set;}
	
	[ForeignKey ("CodUnidade")]
	public virtual UnidMedida UnidMedia {get; set;}
	
	public bool DispEntrega {get; set;}
	public bool EdicLtdaEmbalagem {get; set;}
	
}