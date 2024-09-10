using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ProviderType
{
    public int ProviderTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public bool? CosignRequired { get; set; }

    public virtual ICollection<Physician> Physicians { get; set; } = new List<Physician>();
}
