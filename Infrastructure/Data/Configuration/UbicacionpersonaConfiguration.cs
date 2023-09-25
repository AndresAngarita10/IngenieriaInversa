using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UbicacionpersonaConfiguration : IEntityTypeConfiguration<Ubicacionpersona>
{
    public void Configure(EntityTypeBuilder<Ubicacionpersona> builder)
    {
        builder.HasKey(e => e.IdDireccion).HasName("PRIMARY");

        builder.ToTable("ubicacionpersona");

        builder.HasIndex(e => e.IdCiudad, "FK_idCiudad");

        builder.HasIndex(e => e.IdPersona, "FK_idPersona");

        builder.Property(e => e.IdDireccion).HasColumnName("idDireccion");
        builder.Property(e => e.Bis)
            .HasMaxLength(10)
            .IsFixedLength()
            .HasColumnName("bis");
        builder.Property(e => e.Cardinal)
            .HasMaxLength(10)
            .IsFixedLength()
            .HasColumnName("cardinal");
        builder.Property(e => e.CardinalSec)
            .HasMaxLength(10)
            .IsFixedLength()
            .HasColumnName("cardinalSec");
        builder.Property(e => e.Complemento)
            .HasMaxLength(50)
            .HasColumnName("complemento");
        builder.Property(e => e.IdCiudad).HasColumnName("idCiudad");
        builder.Property(e => e.IdPersona)
            .HasMaxLength(20)
            .HasColumnName("idPersona");
        builder.Property(e => e.Letra)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("letra");
        builder.Property(e => e.LetraSec)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("letraSec");
        builder.Property(e => e.LetraTer)
            .HasMaxLength(2)
            .IsFixedLength()
            .HasColumnName("letraTer");
        builder.Property(e => e.NumeroPri).HasColumnName("numeroPri");
        builder.Property(e => e.NumeroSec).HasColumnName("numeroSec");
        builder.Property(e => e.NumeroTer).HasColumnName("numeroTer");
        builder.Property(e => e.TipoDeVia)
            .HasMaxLength(50)
            .HasColumnName("tipoDeVia");

        builder.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Ubicacionpersonas)
            .HasForeignKey(d => d.IdCiudad)
            .HasConstraintName("FK_idCiudad");

        builder.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Ubicacionpersonas)
            .HasForeignKey(d => d.IdPersona)
            .HasConstraintName("FK_idPersona");
    }
}