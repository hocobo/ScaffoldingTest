using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Program
{
    public int ProgramId { get; set; }

    public string Name { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<ProgramFacility> ProgramFacilities { get; set; } = new List<ProgramFacility>();

    public virtual ICollection<UserTable> Users { get; set; } = new List<UserTable>();
}
