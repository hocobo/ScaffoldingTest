using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class BodySystemType
{
    public short BodySystemTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalLimitsDescription { get; set; }

    public DateTime? LastModified { get; set; }

    public short? ExamTypeCode { get; set; }

    public virtual ICollection<BodySystemAssessment> BodySystemAssessments { get; set; } = new List<BodySystemAssessment>();

    public virtual ExamType? ExamTypeCodeNavigation { get; set; }
}
