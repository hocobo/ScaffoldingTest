using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PregnancyRiskFactor
{
    public byte RiskFactorId { get; set; }

    public string RiskFactorName { get; set; } = null!;

    public string? RiskFactorDescription { get; set; }

    public virtual ICollection<Prenatal> Prenatals { get; set; } = new List<Prenatal>();
}
