using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PatientAlias
{
    public int PatientAliasId { get; set; }

    public string PatientMrn { get; set; } = null!;

    public string? AliasFirstName { get; set; }

    public string? AliasMiddleName { get; set; }

    public string? AliasLastName { get; set; }

    public byte? AliasPriority { get; set; }

    public DateTime LastModified { get; set; }

    public int? EditedBy { get; set; }

    public virtual Patient PatientMrnNavigation { get; set; } = null!;
}
