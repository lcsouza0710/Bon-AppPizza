public class SubtpBebida
{
	[Key]
	public int CodSubtpBebida {get; set;}
	
	[ForeignKey ("CodTpBebida")]
	public virtual TpBebida TpBebida {get; set;}
	
	public string SubtpBebida {get; set;}
	public virtual ICollection<MarcaBebida> Marcas {get; set;}
}