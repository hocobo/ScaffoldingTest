using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientLanguage
{
    public short LanguageId { get; set; }

    public string Mrn { get; set; } = null!;

    public byte IsPrimary { get; set; }

    public DateTime LastModified { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual Patient MrnNavigation { get; set; } = null!;
}
