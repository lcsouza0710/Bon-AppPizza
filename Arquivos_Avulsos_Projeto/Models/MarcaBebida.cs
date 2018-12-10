public class MarcaBebida
{
	[Key]
	public int codMarcaBebida {get; set;}
	
	[ForeignKey ("CodSubtpBebida")]
	public virtual SubtpBebida SubtpBebida {get; set;}
	
	public string Marca {get; set;}
	public bool Diet {get; set;}
	public bool EdicLtda {get; set;}
	public virtual ICollection<Bebida> Bebidas {get; set;}
}