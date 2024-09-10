using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Specialty
{
    public int SpecialtyId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<Physician> Physicians { get; set; } = new List<Physician>();
}
