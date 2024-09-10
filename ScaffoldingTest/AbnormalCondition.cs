using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class AbnormalCondition
{
    public byte AbnormalConditionId { get; set; }

    public string AbnormalConditionName { get; set; } = null!;

    public string? AbnormalConditionDescription { get; set; }

    public virtual ICollection<Newborn> Newborns { get; set; } = new List<Newborn>();
}
