using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PainParameter
{
    public int PainParameterId { get; set; }

    public int PainScaleTypeId { get; set; }

    public string ParameterName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<PainRating> PainRatings { get; set; } = new List<PainRating>();

    public virtual PainScaleType PainScaleType { get; set; } = null!;

    public virtual ICollection<PcapainAssessment> PcapainAssessments { get; set; } = new List<PcapainAssessment>();
}
