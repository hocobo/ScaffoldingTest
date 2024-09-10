using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Requester
{
    public int RequesterId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? CompanyName { get; set; }

    public int? AddressId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public byte RequesterTypeId { get; set; }

    public string RequesterStatusId { get; set; } = null!;

    public string? Comments { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Disclosure> Disclosures { get; set; } = new List<Disclosure>();

    public virtual RequesterStatus RequesterStatus { get; set; } = null!;

    public virtual RequesterType RequesterType { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();
}
