using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PaymentSource
{
    public int PaymentSourceId { get; set; }

    public string WiPopCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<Birth> Births { get; set; } = new List<Birth>();
}
