public class Estado
{
	[Key]
	public long codEstado {get; set;}
	
	[ForeignKey ("CodPais")]
	public virtual Pais Pais {get; set;}
	
	public string Estado {get; set;}
	public string SiglaEstado {get; set;}
	public virtual ICollection<Municipio> Municipio {get; set;}
}