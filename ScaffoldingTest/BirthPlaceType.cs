using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class BirthPlaceType
{
    public byte BirthPlaceTypeId { get; set; }

    public string BirthPlaceTypeName { get; set; } = null!;

    public string? BirthPlaceDescription { get; set; }

    public virtual ICollection<Birth> Births { get; set; } = new List<Birth>();
}
