using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequesterType
{
    public byte RequesterTypeId { get; set; }

    public string RequesterType1 { get; set; } = null!;

    public string? RequesterTypeDescription { get; set; }

    public virtual ICollection<Requester> Requesters { get; set; } = new List<Requester>();
}
