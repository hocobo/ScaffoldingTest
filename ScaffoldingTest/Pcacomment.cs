using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Pcacomment
{
    public int PcacommentId { get; set; }

    public int Pcaid { get; set; }

    public int PcacommentTypeId { get; set; }

    public string? Pcacomment1 { get; set; }

    public DateTime? DateCommentAdded { get; set; }

    public DateTime LastModified { get; set; }

    public virtual Pcarecord Pca { get; set; } = null!;

    public virtual PcacommentType PcacommentType { get; set; } = null!;
}
