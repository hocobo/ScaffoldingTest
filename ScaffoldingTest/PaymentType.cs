using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PaymentType
{
    public byte PaymentTypeId { get; set; }

    public string PaymentType1 { get; set; } = null!;

    public virtual ICollection<DisclosurePayment> DisclosurePayments { get; set; } = new List<DisclosurePayment>();
}
