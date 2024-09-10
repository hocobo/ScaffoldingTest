using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientModeOfContact
{
    public long PatientModeOfContactId { get; set; }

    public long PatientContactId { get; set; }

    public int ModeOfContactId { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual PreferredModeOfContact ModeOfContact { get; set; } = null!;

    public virtual PatientContactDetail PatientContact { get; set; } = null!;
}
