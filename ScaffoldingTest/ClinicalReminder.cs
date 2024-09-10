using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ClinicalReminder
{
    public short ClinicalReminderId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<PatientClinicalReminder> PatientClinicalReminders { get; set; } = new List<PatientClinicalReminder>();
}
