using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class FetalPresentationAtBirth
{
    public byte FetalPresentationAtBirthId { get; set; }

    public string FetalPresentationName { get; set; } = null!;

    public string? FetalPresentationDescription { get; set; }

    public virtual ICollection<LaborAndDelivery> LaborAndDeliveries { get; set; } = new List<LaborAndDelivery>();
}
