using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class EncounterPhysician
{
    public long EncounterPhysiciansId { get; set; }

    public int PhysicianId { get; set; }

    public int PhysicianRoleId { get; set; }

    public DateTime LastModified { get; set; }

    public long? EncounterId { get; set; }

    public virtual Encounter? Encounter { get; set; }

    public virtual Physician Physician { get; set; } = null!;

    public virtual PhysicianRole PhysicianRole { get; set; } = null!;
}
