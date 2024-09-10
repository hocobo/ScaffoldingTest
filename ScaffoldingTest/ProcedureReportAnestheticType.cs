using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ProcedureReportAnestheticType
{
    public long ProcedureReportId { get; set; }

    public int AnestheticTypeId { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual AnestheticType AnestheticType { get; set; } = null!;

    public virtual ProcedureReport ProcedureReport { get; set; } = null!;
}
