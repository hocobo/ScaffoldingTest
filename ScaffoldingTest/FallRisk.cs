using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class FallRisk
{
    public byte FallRiskId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<PatientFallRisk> PatientFallRisks { get; set; } = new List<PatientFallRisk>();
}
