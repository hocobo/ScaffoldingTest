using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class AlertType
{
    public int AlertId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime LastModified { get; set; }

    public virtual ICollection<PatientAlert> PatientAlerts { get; set; } = new List<PatientAlert>();
}
