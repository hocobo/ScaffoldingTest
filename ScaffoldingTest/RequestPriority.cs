using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequestPriority
{
    public string PriorityId { get; set; } = null!;

    public string RequestPriority1 { get; set; } = null!;

    public string? PriorityDescription { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
