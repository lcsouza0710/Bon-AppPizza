publc class Cardapio
{
	[Key]
	public int codCardapio {get; set;}
	
	[ForeignKey ("CodPizzaria")] {get; set}
	public virtual Pizzaria Pizzaria (get; set;}
	
	public virtual ICollection<Pizza> Pizzas {get; set;}
	public virtual ICollection<Bebida> Bebidas {get; set;}
}