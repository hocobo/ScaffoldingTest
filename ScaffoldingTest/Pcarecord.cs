using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Pcarecord
{
    public int Pcaid { get; set; }

    public long EncounterId { get; set; }

    public byte? PainLevelGoal { get; set; }

    public int? PainScaleTypeId { get; set; }

    public decimal? Temperature { get; set; }

    public int? TempRouteTypeId { get; set; }

    public byte? Pulse { get; set; }

    public int? PulseRouteTypeId { get; set; }

    public byte? Respiration { get; set; }

    public short? SystolicBloodPressure { get; set; }

    public short? DiastolicBloodPressure { get; set; }

    public byte? BloodPressureRouteTypeId { get; set; }

    public byte? PulseOximetry { get; set; }

    public int? O2deliveryTypeId { get; set; }

    public string? OxygenFlow { get; set; }

    public decimal? PercentOxygenDelivered { get; set; }

    public decimal? Weight { get; set; }

    public string? WeightUnits { get; set; }

    public decimal? Height { get; set; }

    public string? HeightUnits { get; set; }

    public decimal? BodyMassIndex { get; set; }

    public byte? BmimethodId { get; set; }

    public decimal? HeadCircumference { get; set; }

    public string? HeadCircumferenceUnits { get; set; }

    public DateTime? DateVitalsAdded { get; set; }

    public DateTime LastModified { get; set; }

    public int? EditedBy { get; set; }

    public string? TempUnits { get; set; }

    public virtual BloodPressureRouteType? BloodPressureRouteType { get; set; }

    public virtual Bmimethod? Bmimethod { get; set; }

    public virtual ICollection<CareSystemAssessment> CareSystemAssessments { get; set; } = new List<CareSystemAssessment>();

    public virtual Encounter Encounter { get; set; } = null!;

    public virtual O2deliveryType? O2deliveryType { get; set; }

    public virtual PainScaleType? PainScaleType { get; set; }

    public virtual ICollection<Pcacomment> Pcacomments { get; set; } = new List<Pcacomment>();

    public virtual ICollection<PcapainAssessment> PcapainAssessments { get; set; } = new List<PcapainAssessment>();

    public virtual PulseRouteType? PulseRouteType { get; set; }

    public virtual TempRouteType? TempRouteType { get; set; }
}
