using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class VisitType
{
    public short VisitTypeId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<AdmitOrder> AdmitOrders { get; set; } = new List<AdmitOrder>();
}
