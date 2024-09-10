using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Race
{
    public byte RaceId { get; set; }

    public string Name { get; set; } = null!;

    public string? Category { get; set; }

    public DateTime LastModified { get; set; }

    public byte? WiPopCode { get; set; }

    public virtual ICollection<PatientRace> PatientRaces { get; set; } = new List<PatientRace>();

    public virtual ICollection<BirthFather> BirthFathers { get; set; } = new List<BirthFather>();
}
