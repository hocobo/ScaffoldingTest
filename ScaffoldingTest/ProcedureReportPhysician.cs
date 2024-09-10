using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ProcedureReportPhysician
{
    public long ProcedureReportId { get; set; }

    public int PhysicianId { get; set; }

    public int PhysicianRoleId { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual Physician Physician { get; set; } = null!;

    public virtual ProcedureReport ProcedureReport { get; set; } = null!;
}
