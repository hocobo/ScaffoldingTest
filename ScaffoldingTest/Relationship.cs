using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Relationship
{
    public int RelationshipId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<PatientEmergencyContact> PatientEmergencyContacts { get; set; } = new List<PatientEmergencyContact>();

    public virtual ICollection<PatientInsurance> PatientInsurances { get; set; } = new List<PatientInsurance>();
}
