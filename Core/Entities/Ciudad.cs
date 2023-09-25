using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class Ciudad
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? IddepartamentoFk { get; set; }

    public virtual Departamento? IddepartamentoFkNavigation { get; set; }

    public virtual ICollection<Ubicacionpersona> Ubicacionpersonas { get; set; } = new List<Ubicacionpersona>();
}
