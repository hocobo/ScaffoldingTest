using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class EducationLevel
{
    public byte EducationId { get; set; }

    public string EducationLevel1 { get; set; } = null!;

    public string? EducationLevelDescription { get; set; }

    public virtual ICollection<BirthFather> BirthFathers { get; set; } = new List<BirthFather>();

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
