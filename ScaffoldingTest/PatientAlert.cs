using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientAlert
{
    public long PatientAlertId { get; set; }

    public int? AlertTypeId { get; set; }

    public string Mrn { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public bool IsActive { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Comments { get; set; }

    public virtual AlertType? AlertType { get; set; }

    public virtual ICollection<EncounterAlert> EncounterAlerts { get; set; } = new List<EncounterAlert>();

    public virtual Patient MrnNavigation { get; set; } = null!;

    public virtual ICollection<PatientAdvancedDirective> PatientAdvancedDirectives { get; set; } = new List<PatientAdvancedDirective>();

    public virtual ICollection<PatientAllergy> PatientAllergies { get; set; } = new List<PatientAllergy>();

    public virtual ICollection<PatientClinicalReminder> PatientClinicalReminders { get; set; } = new List<PatientClinicalReminder>();

    public virtual ICollection<PatientFallRisk> PatientFallRisks { get; set; } = new List<PatientFallRisk>();

    public virtual ICollection<PatientRestriction> PatientRestrictions { get; set; } = new List<PatientRestriction>();
}
