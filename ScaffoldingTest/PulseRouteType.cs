using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PulseRouteType
{
    public int PulseRouteTypeId { get; set; }

    public string PulseRouteTypeName { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Pcarecord> Pcarecords { get; set; } = new List<Pcarecord>();
}
