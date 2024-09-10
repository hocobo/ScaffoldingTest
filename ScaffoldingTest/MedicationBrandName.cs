using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class MedicationBrandName
{
    public int MedicationBrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
