using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequestPurpose
{
    public byte PurposeId { get; set; }

    public string RequestPurpose1 { get; set; } = null!;

    public string? PurposeDescription { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
