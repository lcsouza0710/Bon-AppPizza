public class GrupoIngrediente
{
	[Key]
	public int CodGrupo {get; set;}
	
	public string Grupo {get; set;}
	public virtual ICollection<Ingrediente> Ingredientes {get; set;}
}