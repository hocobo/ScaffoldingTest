using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PointOfOrigin
{
    public int PointOfOriginId { get; set; }

    public string WiPopCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? Explaination { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
}
