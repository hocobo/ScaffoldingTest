using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PainRating
{
    public int PainRatingId { get; set; }

    public int PainParameterId { get; set; }

    public byte Value { get; set; }

    public string Description { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual PainParameter PainParameter { get; set; } = null!;

    public virtual PainRatingImage? PainRatingImage { get; set; }

    public virtual ICollection<PcapainAssessment> PcapainAssessments { get; set; } = new List<PcapainAssessment>();
}
