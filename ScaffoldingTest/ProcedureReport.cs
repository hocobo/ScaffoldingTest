using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ProcedureReport
{
    public long EncounterId { get; set; }

    public long ProcedureReportId { get; set; }

    public DateOnly? ProcedureDate { get; set; }

    public string? PreoperativeDiagonsis { get; set; }

    public string? PostoperativeDiagnosis { get; set; }

    public string? OperativeIndications { get; set; }

    public string? ProcedurePerformed { get; set; }

    public string? DescriptionOfProcedure { get; set; }

    public string? Complications { get; set; }

    public decimal? EstiamtedBloodLoss { get; set; }

    public decimal? Drains { get; set; }

    public int? CoSignature { get; set; }

    public int AuthoringProvider { get; set; }

    public DateTime? WrittenDateTime { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int EditedBy { get; set; }

    public virtual Physician AuthoringProviderNavigation { get; set; } = null!;

    public virtual Physician? CoSignatureNavigation { get; set; }

    public virtual Encounter Encounter { get; set; } = null!;

    public virtual ICollection<ProcedureReportAnestheticType> ProcedureReportAnestheticTypes { get; set; } = new List<ProcedureReportAnestheticType>();

    public virtual ICollection<ProcedureReportPhysician> ProcedureReportPhysicians { get; set; } = new List<ProcedureReportPhysician>();
}
