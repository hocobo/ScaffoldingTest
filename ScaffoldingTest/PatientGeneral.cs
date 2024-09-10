using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientGeneral
{
    public string Mrn { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleInitial { get; set; }

    public string Gender { get; set; } = null!;

    public string? LastFourSsn { get; set; }

    public string? PreferredPhone { get; set; }

    public string ResidentAddress { get; set; } = null!;

    public string? PrimaryInsuranceProvider { get; set; }
}
