using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientRace
{
    public byte RaceId { get; set; }

    public string Mrn { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual Patient MrnNavigation { get; set; } = null!;

    public virtual Race Race { get; set; } = null!;
}
