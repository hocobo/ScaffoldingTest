using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<AdmitOrder> AdmitOrders { get; set; } = new List<AdmitOrder>();

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
}
