using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientAdvancedDirective
{
    public long PatientAdvancedDirectiveId { get; set; }

    public long PatientAlertId { get; set; }

    public short AdvancedDirectiveId { get; set; }

    public DateTime LastModified { get; set; }

    public virtual AdvancedDirective AdvancedDirective { get; set; } = null!;

    public virtual PatientAlert PatientAlert { get; set; } = null!;
}
