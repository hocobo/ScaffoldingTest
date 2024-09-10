using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Religion
{
    public short ReligionId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
