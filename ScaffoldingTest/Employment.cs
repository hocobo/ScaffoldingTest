using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Employment
{
    public int EmploymentId { get; set; }

    public string EmployerName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Occupation { get; set; }

    public DateTime LastModified { get; set; }

    public int? AddressId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
