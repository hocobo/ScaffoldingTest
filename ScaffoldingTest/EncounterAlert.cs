using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class EncounterAlert
{
    public long EncounterId { get; set; }

    public long PatientAlertId { get; set; }

    public DateTime LastModified { get; set; }

    public virtual Encounter Encounter { get; set; } = null!;

    public virtual PatientAlert PatientAlert { get; set; } = null!;
}
