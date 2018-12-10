public class Pizza
{
	[Key]
	public long CodPizza {get; set;}
	
	[ForeignKey ("CodCardapio")]
	public virtual Cardapio Cardapio {get; set;}
	
	[ForeignKey ("CodFormato")]
	public virtual FormatoPizza FormatoPizza {get; set;}
	
	[ForeignKey ("CodSabor")]
	public virtual TpSabor TpSabor {get; set;}
	
	[ForeignKey ("CodRecheio")]
	public virtual RecheioBorda RecheioBorda {get; set}
	
	public virtual ICollection<Ingediente> Ingredientes {get; set;}
	
	public float Preco {get; set}
}