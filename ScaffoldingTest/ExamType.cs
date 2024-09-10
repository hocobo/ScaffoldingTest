using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ExamType
{
    public short ExamTypeCode { get; set; }

    public string ExamType1 { get; set; } = null!;

    public DateTime? LastModified { get; set; }

    public virtual ICollection<BodySystemType> BodySystemTypes { get; set; } = new List<BodySystemType>();
}
