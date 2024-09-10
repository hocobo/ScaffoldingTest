using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Facility
{
    public int FacilityId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int AddressId { get; set; }

    public string? Phone { get; set; }

    public DateTime LastModified { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<Birth> Births { get; set; } = new List<Birth>();

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();

    public virtual ICollection<ProgramFacility> ProgramFacilities { get; set; } = new List<ProgramFacility>();

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<UserFacility> UserFacilities { get; set; } = new List<UserFacility>();
}
