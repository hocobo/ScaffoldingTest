using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Encounter
{
    public string Mrn { get; set; } = null!;

    public long? EncounterRestrictionId { get; set; }

    public long EncounterId { get; set; }

    public int FacilityId { get; set; }

    public byte PatientCurrentAge { get; set; }

    public DateTime AdmitDateTime { get; set; }

    public string ChiefComplaint { get; set; } = null!;

    public int? EncounterTypeId { get; set; }

    public int PlaceOfServiceId { get; set; }

    public int AdmitTypeId { get; set; }

    public string? RoomNumber { get; set; }

    public bool FacilityRegistryOptInOut { get; set; }

    public int? DepartmentId { get; set; }

    public int PointOfOriginId { get; set; }

    public long? PaymentId { get; set; }

    public int? DischargeDisposition { get; set; }

    public DateTime LastModified { get; set; }

    public DateTime? DischargeDateTime { get; set; }

    public string? DischargeComment { get; set; }

    public int? PhysicianId { get; set; }

    public string? AdmittingDiagnosis { get; set; }

    public string? HistoryOfPresentIllness { get; set; }

    public string? SignificantFindings { get; set; }

    public string? MedicationsOnDischarge { get; set; }

    public string? DischargeDietInstructions { get; set; }

    public int? CoSignature { get; set; }

    public DateTime? WrittenDateTime { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? EditedBy { get; set; }

    public string? DischargeDispositionNote { get; set; }

    public int? AuthoringProvider { get; set; }

    public string? DischargeHospitalCourse { get; set; }

    public string? DischargeDiagnosis { get; set; }

    public int? DischargeAuthoringProviderId { get; set; }

    public string? DischargeAuthoringProviderSignature { get; set; }

    public DateTime? DischargeAuthoringProviderSignedDate { get; set; }

    public int? DischargeCoSigningProviderId { get; set; }

    public string? DischargeCoSigningProviderSignature { get; set; }

    public DateTime? DischargeCoSigningProviderSignedDate { get; set; }

    public virtual AdmitType AdmitType { get; set; } = null!;

    public virtual Physician? AuthoringProviderNavigation { get; set; }

    public virtual Physician? CoSignatureNavigation { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Physician? DischargeAuthoringProvider { get; set; }

    public virtual Physician? DischargeCoSigningProvider { get; set; }

    public virtual Discharge? DischargeDispositionNavigation { get; set; }

    public virtual ICollection<EncounterAlert> EncounterAlerts { get; set; } = new List<EncounterAlert>();

    public virtual ICollection<EncounterPhysician> EncounterPhysicians { get; set; } = new List<EncounterPhysician>();

    public virtual EncounterType? EncounterType { get; set; }

    public virtual Facility Facility { get; set; } = null!;

    public virtual Patient MrnNavigation { get; set; } = null!;

    public virtual ICollection<OrderInfo> OrderInfos { get; set; } = new List<OrderInfo>();

    public virtual ICollection<Pcarecord> Pcarecords { get; set; } = new List<Pcarecord>();

    public virtual Physician? Physician { get; set; }

    public virtual ICollection<PhysicianAssessment> PhysicianAssessments { get; set; } = new List<PhysicianAssessment>();

    public virtual PlaceOfServiceOutPatient PlaceOfService { get; set; } = null!;

    public virtual PointOfOrigin PointOfOrigin { get; set; } = null!;

    public virtual ICollection<ProcedureReport> ProcedureReports { get; set; } = new List<ProcedureReport>();

    public virtual ICollection<ProgressNote> ProgressNotes { get; set; } = new List<ProgressNote>();
}
