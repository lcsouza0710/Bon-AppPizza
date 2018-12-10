public class TpBebida
{
	[Key]
	public int codTpBebida {get; set;}
	
	public string TpBebida {get; set;}
	public virtual ICollection<SubtpBebida> SubtpBebida {get; set;}
}