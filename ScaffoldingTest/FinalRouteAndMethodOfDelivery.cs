using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class FinalRouteAndMethodOfDelivery
{
    public byte FinalRouteAndMethodId { get; set; }

    public string FinalRouteAndMethodName { get; set; } = null!;

    public string? FinalRouteAndMethodDescription { get; set; }

    public virtual ICollection<LaborAndDelivery> LaborAndDeliveries { get; set; } = new List<LaborAndDelivery>();
}
