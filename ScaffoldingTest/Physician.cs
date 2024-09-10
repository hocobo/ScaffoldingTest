using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Physician
{
    public int PhysicianId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Credentials { get; set; }

    public string? License { get; set; }

    public int? AddressId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public int? SpecialtyId { get; set; }

    public int? ProviderTypeId { get; set; }

    public byte? ProviderStatusId { get; set; }

    public DateTime LastModified { get; set; }

    public short? Pin { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Birth> BirthCertifierOfBirths { get; set; } = new List<Birth>();

    public virtual ICollection<Birth> BirthDeliveringAttendants { get; set; } = new List<Birth>();

    public virtual ICollection<Encounter> EncounterAuthoringProviderNavigations { get; set; } = new List<Encounter>();

    public virtual ICollection<Encounter> EncounterCoSignatureNavigations { get; set; } = new List<Encounter>();

    public virtual ICollection<Encounter> EncounterDischargeAuthoringProviders { get; set; } = new List<Encounter>();

    public virtual ICollection<Encounter> EncounterDischargeCoSigningProviders { get; set; } = new List<Encounter>();

    public virtual ICollection<Encounter> EncounterPhysicians { get; set; } = new List<Encounter>();

    public virtual ICollection<EncounterPhysician> EncounterPhysiciansNavigation { get; set; } = new List<EncounterPhysician>();

    public virtual ICollection<OrderInfo> OrderInfoAuthenticatingProviders { get; set; } = new List<OrderInfo>();

    public virtual ICollection<OrderInfo> OrderInfoOrderCompletedBies { get; set; } = new List<OrderInfo>();

    public virtual ICollection<OrderInfo> OrderInfoOrderingAuthorNavigations { get; set; } = new List<OrderInfo>();

    public virtual ICollection<PatientMedicationList> PatientMedicationLists { get; set; } = new List<PatientMedicationList>();

    public virtual ICollection<PhysicianAssessment> PhysicianAssessmentAuthoringProviderNavigations { get; set; } = new List<PhysicianAssessment>();

    public virtual ICollection<PhysicianAssessment> PhysicianAssessmentCoSignatureNavigations { get; set; } = new List<PhysicianAssessment>();

    public virtual ICollection<PhysicianAssessment> PhysicianAssessmentReferringProviderNavigations { get; set; } = new List<PhysicianAssessment>();

    public virtual ICollection<ProcedureReport> ProcedureReportAuthoringProviderNavigations { get; set; } = new List<ProcedureReport>();

    public virtual ICollection<ProcedureReport> ProcedureReportCoSignatureNavigations { get; set; } = new List<ProcedureReport>();

    public virtual ICollection<ProcedureReportPhysician> ProcedureReportPhysicians { get; set; } = new List<ProcedureReportPhysician>();

    public virtual ICollection<ProgressNote> ProgressNoteCoPhysicians { get; set; } = new List<ProgressNote>();

    public virtual ICollection<ProgressNote> ProgressNotePhysicians { get; set; } = new List<ProgressNote>();

    public virtual ProviderStatus? ProviderStatus { get; set; }

    public virtual ProviderType? ProviderType { get; set; }

    public virtual Specialty? Specialty { get; set; }
}
