using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PcacommentType
{
    public int PcacommentTypeId { get; set; }

    public string PcacommentTypeName { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Pcacomment> Pcacomments { get; set; } = new List<Pcacomment>();
}
