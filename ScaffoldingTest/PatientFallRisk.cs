﻿using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientFallRisk
{
    public long PatientFallRiskId { get; set; }

    public DateTime LastModified { get; set; }

    public long PatientAlertId { get; set; }

    public byte FallRiskId { get; set; }

    public virtual FallRisk FallRisk { get; set; } = null!;

    public virtual PatientAlert PatientAlert { get; set; } = null!;
}
