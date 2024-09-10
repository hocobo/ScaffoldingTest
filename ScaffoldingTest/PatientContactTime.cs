using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientContactTime
{
    public long PatientContactTimeId { get; set; }

    public long PatientContactId { get; set; }

    public int ContactTimeId { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual PreferredContactTime ContactTime { get; set; } = null!;

    public virtual PatientContactDetail PatientContact { get; set; } = null!;
}
