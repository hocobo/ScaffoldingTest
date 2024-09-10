using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PreferredContactTime
{
    public int ContactTimeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<PatientContactTime> PatientContactTimes { get; set; } = new List<PatientContactTime>();
}
