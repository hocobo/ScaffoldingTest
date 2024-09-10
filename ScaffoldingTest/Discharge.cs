using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Discharge
{
    public int DischargeId { get; set; }

    public string? WiPopCode { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
}
