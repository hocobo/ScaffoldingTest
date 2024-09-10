using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PhysicianRole
{
    public int PhysicianRoleId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<EncounterPhysician> EncounterPhysicians { get; set; } = new List<EncounterPhysician>();
}
