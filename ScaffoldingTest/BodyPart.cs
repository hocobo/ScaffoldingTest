using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class BodyPart
{
    public long PartId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
