using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PlaceOfServiceOutPatient
{
    public int PlaceOfServiceId { get; set; }

    public byte WiPopCode { get; set; }

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
}
