using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PhysicianAssessmentType
{
    public short PhysicianAssessmentTypeId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? LastModified { get; set; }

    public virtual ICollection<PhysicianAssessment> PhysicianAssessments { get; set; } = new List<PhysicianAssessment>();
}
