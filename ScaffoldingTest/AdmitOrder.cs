using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class AdmitOrder
{
    public long AdmitOrderId { get; set; }

    public short VisitTypeId { get; set; }

    public int DepartmentId { get; set; }

    public DateTime LastModified { get; set; }

    public long OrderInfoId { get; set; }

    public string? AdmittingDiagnosis { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual OrderInfo OrderInfo { get; set; } = null!;

    public virtual VisitType VisitType { get; set; } = null!;
}
