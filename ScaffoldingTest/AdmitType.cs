using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class AdmitType
{
    public int AdmitTypeId { get; set; }

    public string WiPopCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Explaination { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
}
