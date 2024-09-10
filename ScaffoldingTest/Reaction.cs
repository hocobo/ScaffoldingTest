using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Reaction
{
    public int ReactionId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<PatientAllergy> PatientAllergies { get; set; } = new List<PatientAllergy>();
}
