using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class MedicationDeliveryRoute
{
    public short DeliveryRouteId { get; set; }

    public string DeliveryRouteName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Medication> Medications { get; set; } = new List<Medication>();
}
