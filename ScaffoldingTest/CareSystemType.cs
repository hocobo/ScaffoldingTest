using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class CareSystemType
{
    public short CareSystemTypeId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<CareSystemParameter> CareSystemParameters { get; set; } = new List<CareSystemParameter>();
}
