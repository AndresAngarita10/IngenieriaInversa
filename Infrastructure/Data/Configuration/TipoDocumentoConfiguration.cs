using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipodocumentoConfiguration : IEntityTypeConfiguration<Tipodocumento>
{
    public void Configure(EntityTypeBuilder<Tipodocumento> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("tipodocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Nombre)
            .HasMaxLength(50)
            .HasColumnName("nombre");
    }
}