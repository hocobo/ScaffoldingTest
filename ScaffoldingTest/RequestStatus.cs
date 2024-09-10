using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequestStatus
{
    public string RequestStatusId { get; set; } = null!;

    public string RequestStatus1 { get; set; } = null!;

    public string? StatusDescription { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
