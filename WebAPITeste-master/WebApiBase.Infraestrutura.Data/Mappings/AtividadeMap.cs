using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiBase.Dominio.Models;

namespace WebApiBase.Infraestrutura.Data.Mappings
{
    public class AtividadeMap : IEntityTypeConfiguration<Atividade>
    {
        public void Configure(EntityTypeBuilder<Atividade> builder)
        {
            builder.ToTable("Atividades");

            builder.HasKey(a => a.Id);
            
            builder.Property(a => a.Descricao)
                   .IsRequired()
                   .HasMaxLength(1000);
            
            builder.Property(a => a.DataInicio)
                   .IsRequired();
            
            builder.Property(a => a.DataConclusao);
            
            builder.Property(a=> a.Categoria)
                   .IsRequired();

            builder.Property(a => a.Status)
                   .IsRequired();
        }
    }
}
