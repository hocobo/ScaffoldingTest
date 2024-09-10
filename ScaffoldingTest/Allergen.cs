using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Allergen
{
    public int AllergenId { get; set; }

    public string AllergenName { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<PatientAllergy> PatientAllergies { get; set; } = new List<PatientAllergy>();

    public virtual ICollection<PhysicianAssessment> PhysicianAssessments { get; set; } = new List<PhysicianAssessment>();
}
