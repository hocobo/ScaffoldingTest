using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class DisclosureFeeType
{
    public int DisclosureFeeTypeId { get; set; }

    public decimal FeeAmount { get; set; }

    public string FeeDescription { get; set; } = null!;

    public string? Comments { get; set; }

    public DateOnly EffectiveDate { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public virtual ICollection<Disclosure> Disclosures { get; set; } = new List<Disclosure>();
}
