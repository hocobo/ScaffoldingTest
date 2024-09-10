using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Restriction
{
    public short RestrictionId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<PatientRestriction> PatientRestrictions { get; set; } = new List<PatientRestriction>();
}
