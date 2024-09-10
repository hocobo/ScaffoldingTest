using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class RequestReleaseFormat
{
    public byte ReleaseFormatId { get; set; }

    public string RequestReleaseFormat1 { get; set; } = null!;

    public string? ReleaseFormatDescription { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
