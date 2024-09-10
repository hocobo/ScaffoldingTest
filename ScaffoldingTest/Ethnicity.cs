using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Ethnicity
{
    public byte EthnicityId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public byte? WiPopCode { get; set; }

    public virtual ICollection<BirthFather> BirthFathers { get; set; } = new List<BirthFather>();

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
