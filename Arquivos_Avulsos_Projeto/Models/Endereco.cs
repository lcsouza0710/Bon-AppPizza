public class Enderecos
{
	[Key]
	public long CodEndereco {get; set;}
	
	[ForeignKey ("CodTpLogradouro")]
	public virtual TpLogradouro TpLogradouro {get; set;}
	
	public string Logradouro {get; set;}
	public string Numero {get; set;}
	public string Bairro {get; set;}
	
	[ForeignKey ("CodMunicipio")]
	public virtual Municipio Municipio {get; set;}
	
	public string CEP {get; set;}
}
