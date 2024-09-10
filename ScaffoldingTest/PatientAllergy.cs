using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientAllergy
{
    public long PatientAllergyId { get; set; }

    public int? AllergenId { get; set; }

    public int? ReactionId { get; set; }

    public DateTime LastModified { get; set; }

    public long PatientAlertId { get; set; }

    public int? GenericMedicationId { get; set; }

    public virtual Allergen? Allergen { get; set; }

    public virtual MedicationGenericName? GenericMedication { get; set; }

    public virtual PatientAlert PatientAlert { get; set; } = null!;

    public virtual Reaction? Reaction { get; set; }
}
