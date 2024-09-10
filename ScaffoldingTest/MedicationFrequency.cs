using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class MedicationFrequency
{
    public short MedicationFrequencyId { get; set; }

    public string FrequencyCode { get; set; } = null!;

    public string FrequencyDescription { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public virtual ICollection<PatientMedicationList> PatientMedicationLists { get; set; } = new List<PatientMedicationList>();
}
