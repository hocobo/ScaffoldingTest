using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PhysicianAssessment
{
    public long PhysicianAssessmentId { get; set; }

    public long EncounterId { get; set; }

    public DateOnly? PhysicianAssessmentDate { get; set; }

    public short PhysicianAssessmentTypeId { get; set; }

    public int? ReferringProvider { get; set; }

    public string? ChiefComplaint { get; set; }

    public string? HistoryOfPresentIllness { get; set; }

    public string? SocialHistory { get; set; }

    public string? FamilyHistory { get; set; }

    public string? SignificantDiagnosticTests { get; set; }

    public string? Assessment { get; set; }

    public string? Plan { get; set; }

    public int? CoSignature { get; set; }

    public int AuthoringProvider { get; set; }

    public DateTime? WrittenDateTime { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int EditedBy { get; set; }

    public string? PastMedicalSurgicalHistory { get; set; }

    public string? AuthoringProviderSignature { get; set; }

    public DateTime? AuthoringProviderSignedDate { get; set; }

    public string? CoSigningProviderSignature { get; set; }

    public DateTime? CoSigningProviderSignedDate { get; set; }

    public virtual Physician AuthoringProviderNavigation { get; set; } = null!;

    public virtual ICollection<BodySystemAssessment> BodySystemAssessments { get; set; } = new List<BodySystemAssessment>();

    public virtual Physician? CoSignatureNavigation { get; set; }

    public virtual Encounter Encounter { get; set; } = null!;

    public virtual PhysicianAssessmentType PhysicianAssessmentType { get; set; } = null!;

    public virtual Physician? ReferringProviderNavigation { get; set; }

    public virtual ICollection<Allergen> Allergens { get; set; } = new List<Allergen>();
}
