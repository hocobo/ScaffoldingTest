using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PainScaleType
{
    public int PainScaleTypeId { get; set; }

    public string PainScaleTypeName { get; set; } = null!;

    public string? UseDescription { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<PainParameter> PainParameters { get; set; } = new List<PainParameter>();

    public virtual ICollection<Pcarecord> Pcarecords { get; set; } = new List<Pcarecord>();
}
