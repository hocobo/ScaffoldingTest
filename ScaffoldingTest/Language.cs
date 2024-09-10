using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Language
{
    public short LanguageId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<PatientLanguage> PatientLanguages { get; set; } = new List<PatientLanguage>();
}
