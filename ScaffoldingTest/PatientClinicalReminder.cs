using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientClinicalReminder
{
    public long PatientClinicalReminderId { get; set; }

    public long PatientAlertId { get; set; }

    public short ClinicalReminderId { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ClinicalReminder ClinicalReminder { get; set; } = null!;

    public virtual PatientAlert PatientAlert { get; set; } = null!;
}
