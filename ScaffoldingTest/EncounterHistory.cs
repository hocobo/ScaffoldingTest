using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class EncounterHistory
{
    public string Mrn { get; set; } = null!;

    public long EncounterId { get; set; }

    public string ChiefComplaint { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Explaination { get; set; }

    public int? AdmitDate { get; set; }

    public string FacilityName { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public string DischargeDate { get; set; } = null!;
}
