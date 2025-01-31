﻿using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientEmergencyContact
{
    public long EmergencyContactId { get; set; }

    public string Mrn { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string? ContactPhone { get; set; }

    public int? ContactAddressId { get; set; }

    public int? ContactRelationshipId { get; set; }

    public DateTime LastModified { get; set; }

    public string? Email { get; set; }

    public virtual Address? ContactAddress { get; set; }

    public virtual Relationship? ContactRelationship { get; set; }

    public virtual Patient MrnNavigation { get; set; } = null!;
}
