using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Persona
{
    public string Id { get; set; } = null!;

    public string? Nombre { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public int? IdDocumento { get; set; }

    public virtual Tipodocumento? IdDocumentoNavigation { get; set; }

    public virtual ICollection<Ubicacionpersona> Ubicacionpersonas { get; set; } = new List<Ubicacionpersona>();
}
