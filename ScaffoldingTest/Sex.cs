using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Sex
{
    public byte SexId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Newborn> Newborns { get; set; } = new List<Newborn>();

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
