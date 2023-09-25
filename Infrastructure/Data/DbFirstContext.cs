using System;
using System.Collections.Generic;
using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public partial class DbFirstContext : DbContext
{
    public DbFirstContext()
    {
    }

    public DbFirstContext(DbContextOptions<DbFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ciudad> Ciudades { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Pais> Paises { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Tipodocumento> Tipodocumentos { get; set; }

    public virtual DbSet<Ubicacionpersona> Ubicacionpersonas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
