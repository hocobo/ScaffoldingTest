﻿using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ProgressNote
{
    public long ProgressNoteId { get; set; }

    public long EncounterId { get; set; }

    public int NoteTypeId { get; set; }

    public DateTime? WrittenDate { get; set; }

    public string? Note { get; set; }

    public int? CoPhysicianId { get; set; }

    public int PhysicianId { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int EditedBy { get; set; }

    public string? AuthoringProviderSignature { get; set; }

    public DateTime? AuthoringProviderSignedDate { get; set; }

    public string? CoSigningProviderSignature { get; set; }

    public DateTime? CoSigningProviderSignedDate { get; set; }

    public virtual Physician? CoPhysician { get; set; }

    public virtual Encounter Encounter { get; set; } = null!;

    public virtual NoteType NoteType { get; set; } = null!;

    public virtual Physician Physician { get; set; } = null!;
}
