using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ProviderStatus
{
    public byte ProviderStatusId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? LastModified { get; set; }

    public virtual ICollection<Physician> Physicians { get; set; } = new List<Physician>();
}
