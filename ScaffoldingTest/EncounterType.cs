using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class EncounterType
{
    public int EncounterTypeId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
}
