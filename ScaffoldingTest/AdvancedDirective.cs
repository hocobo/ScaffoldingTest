using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class AdvancedDirective
{
    public short AdvancedDirectiveId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PatientAdvancedDirective> PatientAdvancedDirectives { get; set; } = new List<PatientAdvancedDirective>();
}
