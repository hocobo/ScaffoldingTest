using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class GenderPronoun
{
    public byte GenderPronounId { get; set; }

    public string GenderPronouns { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
