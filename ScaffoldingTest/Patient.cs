using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Patient
{
    public string Mrn { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? MaidenName { get; set; }

    public short? ReligionId { get; set; }

    public string? AliasFirstName { get; set; }

    public string? AliasMiddleName { get; set; }

    public string? AliasLastName { get; set; }

    public string? MothersMaidenName { get; set; }

    public string? Ssn { get; set; }

    public DateOnly? Dob { get; set; }

    public byte? SexId { get; set; }

    public byte? GenderId { get; set; }

    public bool DeceasedLiving { get; set; }

    public bool InterpreterNeeded { get; set; }

    public byte? MaritalStatusId { get; set; }

    public byte? EthnicityId { get; set; }

    public int? EmploymentId { get; set; }

    public DateTime LastModified { get; set; }

    public int? EditedBy { get; set; }

    public DateOnly? DeathDate { get; set; }

    public bool IsCurrentMilitaryServiceMember { get; set; }

    public bool IsVeteran { get; set; }

    public byte? LegalStatusId { get; set; }

    public byte? GenderPronounId { get; set; }

    public byte? EducationId { get; set; }

    public string? Birthplace { get; set; }

    public virtual ICollection<Birth> Births { get; set; } = new List<Birth>();

    public virtual EducationLevel? Education { get; set; }

    public virtual Employment? Employment { get; set; }

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();

    public virtual Ethnicity? Ethnicity { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual GenderPronoun? GenderPronoun { get; set; }

    public virtual LegalStatus? LegalStatus { get; set; }

    public virtual MaritalStatus? MaritalStatus { get; set; }

    public virtual ICollection<Newborn> Newborns { get; set; } = new List<Newborn>();

    public virtual ICollection<PatientAlert> PatientAlerts { get; set; } = new List<PatientAlert>();

    public virtual ICollection<PatientAlias> PatientAliases { get; set; } = new List<PatientAlias>();

    public virtual ICollection<PatientContactDetail> PatientContactDetails { get; set; } = new List<PatientContactDetail>();

    public virtual ICollection<PatientEmergencyContact> PatientEmergencyContacts { get; set; } = new List<PatientEmergencyContact>();

    public virtual ICollection<PatientInsurance> PatientInsurances { get; set; } = new List<PatientInsurance>();

    public virtual ICollection<PatientLanguage> PatientLanguages { get; set; } = new List<PatientLanguage>();

    public virtual ICollection<PatientMedicationList> PatientMedicationLists { get; set; } = new List<PatientMedicationList>();

    public virtual ICollection<PatientRace> PatientRaces { get; set; } = new List<PatientRace>();

    public virtual Religion? Religion { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual Sex? Sex { get; set; }
}
