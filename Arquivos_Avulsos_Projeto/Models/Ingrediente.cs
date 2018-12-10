public class Ingrediente
{
	[Key]
	public int CodIngrediente {get; set;}
	
	[ForeignKey ("CodGrupo")]
	public virtual GrupoIngredientes GrupoIngredientes {get; set;}
	
	public string Ingrediente {get; set;}
}