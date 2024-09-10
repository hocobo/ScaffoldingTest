using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientRestriction
{
    public long RestrictionId { get; set; }

    public DateTime LastModified { get; set; }

    public short RestrictionTypeId { get; set; }

    public long PatientAlertId { get; set; }

    public virtual PatientAlert PatientAlert { get; set; } = null!;

    public virtual Restriction RestrictionType { get; set; } = null!;
}
