using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class PainRatingImage
{
    public int PainRatingId { get; set; }

    public byte[]? Image { get; set; }

    public DateTime LastModified { get; set; }

    public virtual PainRating PainRating { get; set; } = null!;
}
