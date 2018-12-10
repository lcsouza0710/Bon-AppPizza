using Microsoft.EntityFrameworkCore;
using Bonn_App_Pizza.Models.Entidades;

namespace Bonn_App_Pizza
{
    public class BonAppPizzaContext : DbContext
    {
        public DbSet<TpLogradouro> TiposLogradouros { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Pizzaria> Pizzarias { get; set; }

        public BonAppPizzaContext(DbContextOptions<BonAppPizzaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzaria>().HasKey(p => p.IdPizzaria);
            modelBuilder.Entity<Pais>().HasKey(p => p.IdPais);
            modelBuilder.Entity<Estado>().HasKey(e => e.IdEstado);
            modelBuilder.Entity<Municipio>().HasKey(m => m.IdMunicipio);
            modelBuilder.Entity<TpLogradouro>().HasKey(t => t.IDTpLogradouro);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}

    
