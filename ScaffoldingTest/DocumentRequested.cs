using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class DocumentRequested
{
    public int DocumentRequestedId { get; set; }

    public string DocumentRequested1 { get; set; } = null!;

    public string? DocumentRequestedDescription { get; set; }

    public virtual ICollection<RequestedItem> RequestedItems { get; set; } = new List<RequestedItem>();
}
