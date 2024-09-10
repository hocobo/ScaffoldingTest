using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Address
{
    public int AddressId { get; set; }

    public string Address1 { get; set; } = null!;

    public string? Address2 { get; set; }

    public string PostalCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public int CountryId { get; set; }

    public DateTime LastModified { get; set; }

    public string? County { get; set; }

    public virtual ICollection<Birth> Births { get; set; } = new List<Birth>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Employment> Employments { get; set; } = new List<Employment>();

    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();

    public virtual ICollection<PatientContactDetail> PatientContactDetailMailingAddresses { get; set; } = new List<PatientContactDetail>();

    public virtual ICollection<PatientContactDetail> PatientContactDetailResidenceAddresses { get; set; } = new List<PatientContactDetail>();

    public virtual ICollection<PatientEmergencyContact> PatientEmergencyContacts { get; set; } = new List<PatientEmergencyContact>();

    public virtual ICollection<Physician> Physicians { get; set; } = new List<Physician>();

    public virtual ICollection<Requester> Requesters { get; set; } = new List<Requester>();
}
