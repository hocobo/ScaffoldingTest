using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class CareSystemAssessment
{
    public int CareSystemAssessmentId { get; set; }

    public int Pcaid { get; set; }

    public short CareSystemParameterId { get; set; }

    public bool IsWithinNormalLimits { get; set; }

    public string? Comment { get; set; }

    public DateTime LastModified { get; set; }

    public virtual CareSystemParameter CareSystemParameter { get; set; } = null!;

    public virtual Pcarecord Pca { get; set; } = null!;
}
