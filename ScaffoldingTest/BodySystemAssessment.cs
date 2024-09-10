﻿using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class BodySystemAssessment
{
    public long BodySystemAssessmentId { get; set; }

    public long? PhysicianAssessmentId { get; set; }

    public short? BodySystemTypeId { get; set; }

    public bool? IsWithinNormalLimits { get; set; }

    public string? Comment { get; set; }

    public DateTime? LastModified { get; set; }

    public virtual BodySystemType? BodySystemType { get; set; }

    public virtual PhysicianAssessment? PhysicianAssessment { get; set; }
}
