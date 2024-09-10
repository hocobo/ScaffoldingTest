using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class OrderType
{
    public int OrderTypeId { get; set; }

    public string OrderName { get; set; } = null!;

    public virtual ICollection<OrderInfo> OrderInfos { get; set; } = new List<OrderInfo>();
}
