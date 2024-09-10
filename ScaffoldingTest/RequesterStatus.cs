using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequesterStatus
{
    public string RequesterStatusId { get; set; } = null!;

    public string RequesterStatus1 { get; set; } = null!;

    public string? RequesterStatusDescription { get; set; }

    public virtual ICollection<Requester> Requesters { get; set; } = new List<Requester>();
}
