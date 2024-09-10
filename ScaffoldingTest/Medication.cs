using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Medication
{
    public int MedicationId { get; set; }

    public string Ndc { get; set; } = null!;

    public int BrandNameId { get; set; }

    public int GenericNameId { get; set; }

    public string ActiveStrength { get; set; } = null!;

    public string ActiveIngredientUnits { get; set; } = null!;

    public short DosageFormId { get; set; }

    public short DeliveryRouteId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual MedicationBrandName BrandName { get; set; } = null!;

    public virtual MedicationDeliveryRoute DeliveryRoute { get; set; } = null!;

    public virtual MedicationDosageForm DosageForm { get; set; } = null!;

    public virtual MedicationGenericName GenericName { get; set; } = null!;

    public virtual ICollection<PatientMedicationList> PatientMedicationLists { get; set; } = new List<PatientMedicationList>();
}
