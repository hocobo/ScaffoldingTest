using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class UserFacility
{
    public int UserId { get; set; }

    public int FacilityId { get; set; }

    public DateTime LastModified { get; set; }

    public virtual Facility Facility { get; set; } = null!;

    public virtual UserTable User { get; set; } = null!;
}
