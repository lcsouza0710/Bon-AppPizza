public class BonAppPizzaContext : DbContext
{
	public DbSet<Pais> Pais {get; set;}
	public DbSet<Estado> Estado {get; set;}
	public DbSet<Municipio> Municipio {get; set;}
	public DbSet<TpLogradouro> TpLogradouro {get; set;}
	public DbSet<Endereco> Endereco {get; set;}
	
	public DbSet<Pizzaria> Pizzaria {get; set;}
	public DbSet<ServicosPizzaria> ServicosPizzaria {get; set;}
	public DbSet<EstacionPizzaria> EstacionPizzaria {get; set;}
	public DbSet<PromoRodizio> PromoRodizio {get; set;}
	public DbSet<Cardapio> Cardapio {get; set;}
	public DbSet<Pizza> Pizza {get; set;}
	
	public DbSet<FormatoPizza> FormatoPizza {get; set;}
	public DbSet<TpSabor> TpSabor {get; set;}
	public DbSet<EstiloBorda> EstiloBorda {get; set;}
	public DbSet<RecheioBorda> RecheioBorda {get; set;}
	public DbSet<GrupoIngrediente> GrupoIngrediente {get; set;}
	public DbSet<Ingrediente> Ingrediente {get; set;}
	
	public DbSet<TpBebida> TbBebida {get; set;}
	public DbSet<SubtpBebida> SubtpBebida {get; set;}
	public DbSet<MarcaBebida> MarcaBebida {get; set;}
	public DbSet<EmbalagemBebida> EmbalagemBebida {get; set;}
	public DbSet<UnidMedida> UnidMedida {get; set;}
	public DbSet<Bebida> Bebida {get; set;}
	
	public DbSet<TpCartao> TpCartao {get; set;}
	public DbSet<Cartao> Cartao {get; set;}
	
}