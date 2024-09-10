using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class OrderInfo
{
    public long OrderInfoId { get; set; }

    public long EncounterId { get; set; }

    public int OrderTypeId { get; set; }

    public int OrderingAuthor { get; set; }

    public DateTime OrderDate { get; set; }

    public int PriorityId { get; set; }

    public bool? CoAuthorApproved { get; set; }

    public DateTime ApprovedDate { get; set; }

    public string? Notes { get; set; }

    public bool IsOrderComplete { get; set; }

    public DateTime? OrderCompletedDateTime { get; set; }

    public int? OrderCompletedById { get; set; }

    public bool IsVerbalOrder { get; set; }

    public int? AuthenticatingProviderId { get; set; }

    public string? AuthorEsignature { get; set; }

    public string? AuthenticatingProviderEsignature { get; set; }

    public virtual ICollection<AdmitOrder> AdmitOrders { get; set; } = new List<AdmitOrder>();

    public virtual Physician? AuthenticatingProvider { get; set; }

    public virtual Encounter Encounter { get; set; } = null!;

    public virtual Physician? OrderCompletedBy { get; set; }

    public virtual OrderType OrderType { get; set; } = null!;

    public virtual Physician OrderingAuthorNavigation { get; set; } = null!;

    public virtual Priority Priority { get; set; } = null!;
}
