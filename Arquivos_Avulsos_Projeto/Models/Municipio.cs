public class Municipio
{
	[Key]
	public long CodMunicipio {get; set;}
	
	[ForeignKey ("CodEstado")]
	public virtual Estado Estado {get; set}
	
	public string Municipio {get; set;}
	public virtual ICollection<Endereco> Endereco {get; set;}
}
