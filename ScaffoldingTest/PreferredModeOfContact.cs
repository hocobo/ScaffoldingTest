using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PreferredModeOfContact
{
    public int ModeOfContactId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<PatientModeOfContact> PatientModeOfContacts { get; set; } = new List<PatientModeOfContact>();
}
