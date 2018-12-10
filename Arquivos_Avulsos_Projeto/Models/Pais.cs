public class Pais
{
	[Key]
	public int CodPais {get; set;}
	
	public string Pais {get; set;}
	public virtual ICollection<Estado> Estados {get; set;}
}