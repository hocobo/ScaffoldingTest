using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class CongenitalAnomaly
{
    public byte CongenitalAnomalyId { get; set; }

    public string CongenitalAnomalyName { get; set; } = null!;

    public string? CongenitalAnomalyDescription { get; set; }

    public virtual ICollection<Newborn> Newborns { get; set; } = new List<Newborn>();
}
