using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Test
{
    public long TestId { get; set; }

    public long TestCategoryId { get; set; }

    public string TestName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual TestCategory TestCategory { get; set; } = null!;

    public virtual ICollection<BodyPart> Parts { get; set; } = new List<BodyPart>();
}
