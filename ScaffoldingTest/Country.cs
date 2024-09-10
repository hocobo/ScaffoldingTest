using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Country
{
    public int CountryId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime LastModified { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
}
