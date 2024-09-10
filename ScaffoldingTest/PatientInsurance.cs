using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientInsurance
{
    public int PatientInsuranceId { get; set; }

    public string Mrn { get; set; } = null!;

    public byte InsuranceOrder { get; set; }

    public string Guarantor { get; set; } = null!;

    public string? InsuranceProviderName { get; set; }

    public string? Subscriber { get; set; }

    public int? SubscriberRelationshipId { get; set; }

    public string? SubscriberNumber { get; set; }

    public string? GroupNumber { get; set; }

    public string? PlanName { get; set; }

    public string? PlanNumber { get; set; }

    public DateOnly? EffectiveDate { get; set; }

    public string? Notes { get; set; }

    public virtual Patient MrnNavigation { get; set; } = null!;

    public virtual Relationship? SubscriberRelationship { get; set; }
}
