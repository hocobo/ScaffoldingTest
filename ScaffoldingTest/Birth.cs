using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class Birth
{
    public int BirthId { get; set; }

    public string MotherMrn { get; set; } = null!;

    public bool? IsWctmcbirth { get; set; }

    public int? FacilityId { get; set; }

    public int? AddressId { get; set; }

    public byte? BirthPlaceTypeId { get; set; }

    public bool? IsPlannedHomeBirth { get; set; }

    public int? DeliveringAttendantId { get; set; }

    public int? CertifierOfBirthId { get; set; }

    public bool? IsMotherTransferred { get; set; }

    public string? FacilityTransferredFromName { get; set; }

    public byte? Plurality { get; set; }

    public int? DeliveryPaymentSourceId { get; set; }

    public int? BirthFatherId { get; set; }

    public bool? PaternityAcknowledgementSigned { get; set; }

    public string? CertifierSignature { get; set; }

    public DateOnly? DateCertified { get; set; }

    public DateOnly? DateFiledByRegistrar { get; set; }

    public string? Comments { get; set; }

    public virtual Address? Address { get; set; }

    public virtual BirthFather? BirthFather { get; set; }

    public virtual BirthPlaceType? BirthPlaceType { get; set; }

    public virtual Physician? CertifierOfBirth { get; set; }

    public virtual Physician? DeliveringAttendant { get; set; }

    public virtual PaymentSource? DeliveryPaymentSource { get; set; }

    public virtual Facility? Facility { get; set; }

    public virtual Patient MotherMrnNavigation { get; set; } = null!;

    public virtual ICollection<Newborn> Newborns { get; set; } = new List<Newborn>();

    public virtual ICollection<Prenatal> Prenatals { get; set; } = new List<Prenatal>();
}
