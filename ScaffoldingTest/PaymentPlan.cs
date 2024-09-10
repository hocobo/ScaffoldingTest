using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PaymentPlan
{
    public int PaymentPlanId { get; set; }

    public string WiPopCode { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }
}
