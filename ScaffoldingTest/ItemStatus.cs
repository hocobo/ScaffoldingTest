using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ItemStatus
{
    public string ItemStatusId { get; set; } = null!;

    public string ItemStatus1 { get; set; } = null!;

    public string? ItemStatusDescription { get; set; }

    public virtual ICollection<RequestedItem> RequestedItems { get; set; } = new List<RequestedItem>();
}
