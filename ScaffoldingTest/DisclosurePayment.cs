using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class DisclosurePayment
{
    public int DisclosurePaymentId { get; set; }

    public int DisclosureId { get; set; }

    public byte PaymentTypeId { get; set; }

    public decimal PaymentAmount { get; set; }

    public DateOnly PaymentDate { get; set; }

    public virtual Disclosure Disclosure { get; set; } = null!;

    public virtual PaymentType PaymentType { get; set; } = null!;
}
