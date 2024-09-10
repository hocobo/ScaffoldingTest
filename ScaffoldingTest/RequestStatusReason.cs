using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequestStatusReason
{
    public byte RequestStatusReasonId { get; set; }

    public string RequestStatusReason1 { get; set; } = null!;

    public string? StatusReasonDescription { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
