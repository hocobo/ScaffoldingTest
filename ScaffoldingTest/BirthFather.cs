using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class BirthFather
{
    public int BirthFatherId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Suffix { get; set; }

    public DateOnly? Dob { get; set; }

    public string? FatherBirthplace { get; set; }

    public string? Ssn { get; set; }

    public byte? EducationId { get; set; }

    public byte? EthnicityId { get; set; }

    public virtual ICollection<Birth> Births { get; set; } = new List<Birth>();

    public virtual EducationLevel? Education { get; set; }

    public virtual Ethnicity? Ethnicity { get; set; }

    public virtual ICollection<Race> Races { get; set; } = new List<Race>();
}
