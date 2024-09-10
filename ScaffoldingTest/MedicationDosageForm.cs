using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class MedicationDosageForm
{
    public short DosageFormId { get; set; }

    public string DosageForm { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
