using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class O2deliveryType
{
    public int O2deliveryTypeId { get; set; }

    public string O2deliveryTypeName { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Pcarecord> Pcarecords { get; set; } = new List<Pcarecord>();
}
