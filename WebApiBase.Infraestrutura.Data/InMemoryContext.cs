using Microsoft.EntityFrameworkCore;
using WebApiBase.Dominio.Models;

namespace WebApiBase.Infraestrutura.Data
{
    public class InMemoryContext : DbContext
    {
        public InMemoryContext() { }
        public InMemoryContext(DbContextOptions<InMemoryContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("AtividadeDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<Atividade> Atividades { get; set; }
    }
}