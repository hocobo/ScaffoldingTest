using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class TestCategory
{
    public long TestCategoryId { get; set; }

    public string? CategoryDescription { get; set; }

    public string TestCategoryName { get; set; } = null!;

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
