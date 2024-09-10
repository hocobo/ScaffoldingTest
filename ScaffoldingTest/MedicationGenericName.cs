using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class MedicationGenericName
{
    public int MedicationGenericId { get; set; }

    public string GenericName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();

    public virtual ICollection<PatientAllergy> PatientAllergies { get; set; } = new List<PatientAllergy>();
}
