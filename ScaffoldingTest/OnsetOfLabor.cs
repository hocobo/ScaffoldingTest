using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class OnsetOfLabor
{
    public byte OnsetOfLaborId { get; set; }

    public string OnsetOfLaborName { get; set; } = null!;

    public string? OnsetOfLaborDescription { get; set; }

    public virtual ICollection<LaborAndDelivery> LaborAndDeliveries { get; set; } = new List<LaborAndDelivery>();
}
