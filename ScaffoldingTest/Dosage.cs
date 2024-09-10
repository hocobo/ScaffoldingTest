using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Dosage
{
    public int DosageId { get; set; }

    public decimal Amount { get; set; }

    public string UnitOfMeasurement { get; set; } = null!;
}
