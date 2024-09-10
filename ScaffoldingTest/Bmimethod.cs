using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Bmimethod
{
    public byte BmimethodId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Pcarecord> Pcarecords { get; set; } = new List<Pcarecord>();
}
