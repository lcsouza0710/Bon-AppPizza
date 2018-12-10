public class RecheioBorda
{
	[Key]
	public int codRecheio {get; set;}
	
	[ForeignKey ("CodTpSabor")]
	public virtual TpSabor TpSabor {get; set;}
	
	public string Recheio {get; set;}
}