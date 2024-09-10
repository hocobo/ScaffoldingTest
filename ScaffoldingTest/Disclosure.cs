using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Disclosure
{
    public int DisclosureId { get; set; }

    public int? RequestId { get; set; }

    public int? RequesterId { get; set; }

    public DateOnly? DisclosureDate { get; set; }

    public int? InvoiceNumber { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public bool? IsPaymentRequired { get; set; }

    public string? Comments { get; set; }

    public virtual ICollection<DisclosurePayment> DisclosurePayments { get; set; } = new List<DisclosurePayment>();

    public virtual Request? Request { get; set; }

    public virtual Requester? Requester { get; set; }

    public virtual ICollection<DisclosureFeeType> DisclosureFeeTypes { get; set; } = new List<DisclosureFeeType>();

    public virtual ICollection<RequestedItem> RequestedItems { get; set; } = new List<RequestedItem>();
}
