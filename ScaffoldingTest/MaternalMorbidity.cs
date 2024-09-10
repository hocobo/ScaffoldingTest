using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class MaternalMorbidity
{
    public byte MaternalMorbidityId { get; set; }

    public string MaternalMorbidityName { get; set; } = null!;

    public string? MaternalMorbidityDescription { get; set; }

    public virtual ICollection<LaborAndDelivery> LaborAndDeliveries { get; set; } = new List<LaborAndDelivery>();
}
