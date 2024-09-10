using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequestedItem
{
    public int RequestedItemId { get; set; }

    public int DocumentRequestedId { get; set; }

    public string ItemStatusId { get; set; } = null!;

    public bool? IsDisclosed { get; set; }

    public string? Comments { get; set; }

    public virtual DocumentRequested DocumentRequested { get; set; } = null!;

    public virtual ItemStatus ItemStatus { get; set; } = null!;

    public virtual ICollection<Disclosure> Disclosures { get; set; } = new List<Disclosure>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
