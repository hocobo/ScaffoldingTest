using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Newborn
{
    public int NewbornId { get; set; }

    public int? BirthId { get; set; }

    public string? NewbornMrn { get; set; }

    public DateTime? DateAndTimeOfBirth { get; set; }

    public decimal? BirthWeightInLbs { get; set; }

    public byte? GestationalAgeEstimateInWeeks { get; set; }

    public byte? SexId { get; set; }

    public byte? ApgarScoreAt1Minute { get; set; }

    public byte? ApgarScoreAt5Minutes { get; set; }

    public byte? ApgarScoreAt10Minutes { get; set; }

    public bool? IsSingleBirth { get; set; }

    public byte? BirthOrder { get; set; }

    public bool? InfantTransferredWithin24Hours { get; set; }

    public string? NameOfFacilityTransferredTo { get; set; }

    public bool? IsInfantStillLiving { get; set; }

    public bool? IsInfantBeingBreastfed { get; set; }

    public bool? SsnrequestedForChild { get; set; }

    public string? Comments { get; set; }

    public virtual Birth? Birth { get; set; }

    public virtual ICollection<LaborAndDelivery> LaborAndDeliveries { get; set; } = new List<LaborAndDelivery>();

    public virtual Patient? NewbornMrnNavigation { get; set; }

    public virtual Sex? Sex { get; set; }

    public virtual ICollection<AbnormalCondition> AbnormalConditions { get; set; } = new List<AbnormalCondition>();

    public virtual ICollection<CongenitalAnomaly> CongenitalAnomalies { get; set; } = new List<CongenitalAnomaly>();
}
