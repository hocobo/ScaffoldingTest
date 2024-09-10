using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PregnancyInfection
{
    public byte InfectionId { get; set; }

    public string InfectionName { get; set; } = null!;

    public string? InfectionDescription { get; set; }

    public virtual ICollection<Prenatal> Prenatals { get; set; } = new List<Prenatal>();
}
