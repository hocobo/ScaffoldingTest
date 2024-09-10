using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientMedicationList
{
    public long PatientMedicationListId { get; set; }

    public string Mrn { get; set; } = null!;

    public int MedicationId { get; set; }

    public short FrequencyId { get; set; }

    public string? OtherFrequencyDescription { get; set; }

    public string Indication { get; set; } = null!;

    public int? OrderingProviderId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool IsActive { get; set; }

    public string? Comments { get; set; }

    public DateTime LastModified { get; set; }

    public virtual MedicationFrequency Frequency { get; set; } = null!;

    public virtual Medication Medication { get; set; } = null!;

    public virtual Patient MrnNavigation { get; set; } = null!;

    public virtual Physician? OrderingProvider { get; set; }
}
