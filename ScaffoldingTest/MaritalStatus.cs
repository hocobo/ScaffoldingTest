using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class MaritalStatus
{
    public byte MaritalStatusId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
