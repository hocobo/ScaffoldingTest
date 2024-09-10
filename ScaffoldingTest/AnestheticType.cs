using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class AnestheticType
{
    public int AnestheticTypeId { get; set; }

    public string AnestheticType1 { get; set; } = null!;

    public DateTime? LastModified { get; set; }

    public virtual ICollection<ProcedureReportAnestheticType> ProcedureReportAnestheticTypes { get; set; } = new List<ProcedureReportAnestheticType>();
}
