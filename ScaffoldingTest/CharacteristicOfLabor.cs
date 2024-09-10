using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class CharacteristicOfLabor
{
    public byte CharacteristicId { get; set; }

    public string CharacteristicName { get; set; } = null!;

    public string? CharacteristicDescription { get; set; }

    public virtual ICollection<LaborAndDelivery> LaborAndDeliveries { get; set; } = new List<LaborAndDelivery>();
}
