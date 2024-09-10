using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class TempRouteType
{
    public int TempRouteTypeId { get; set; }

    public string TempRouteTypeName { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Pcarecord> Pcarecords { get; set; } = new List<Pcarecord>();
}
