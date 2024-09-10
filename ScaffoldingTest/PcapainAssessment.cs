using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PcapainAssessment
{
    public long PainAssessmentId { get; set; }

    public int Pcaid { get; set; }

    public int PainParameterId { get; set; }

    public int PainRatingId { get; set; }

    public DateTime LastModified { get; set; }

    public virtual PainParameter PainParameter { get; set; } = null!;

    public virtual PainRating PainRating { get; set; } = null!;

    public virtual Pcarecord Pca { get; set; } = null!;
}
