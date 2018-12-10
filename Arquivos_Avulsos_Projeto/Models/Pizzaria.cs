public class Pizzaria
{
	[Key]
	public long CodPizzaria {get; set;}
	
	public string NomeDivulgacao {get; set;}
	public string RazaoSocial {get; set;}
	public string CNPJ {get; set;}
	public string Proprietario {get; set;}
	
	[ForeignKey ("CodEndereco")]
	public virtual Endereco Endereco {get; set;}
}