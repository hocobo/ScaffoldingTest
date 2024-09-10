using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class CareSystemParameter
{
    public short CareSystemParameterId { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalLimitsDescription { get; set; }

    public short CareSystemTypeId { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<CareSystemAssessment> CareSystemAssessments { get; set; } = new List<CareSystemAssessment>();

    public virtual CareSystemType CareSystemType { get; set; } = null!;
}
