using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class LegalStatus
{
    public byte LegalStatusId { get; set; }

    public string LegalStatusName { get; set; } = null!;

    public bool RequiresLegalGuardian { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
