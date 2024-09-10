using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class NoteType
{
    public int NoteTypeId { get; set; }

    public string NoteType1 { get; set; } = null!;

    public DateTime? LastModified { get; set; }

    public virtual ICollection<ProgressNote> ProgressNotes { get; set; } = new List<ProgressNote>();
}
