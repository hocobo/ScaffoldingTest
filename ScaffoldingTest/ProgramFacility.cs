﻿using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class ProgramFacility
{
    public int ProgramFacilitiesId { get; set; }

    public int? ProgramId { get; set; }

    public int? FacilityId { get; set; }

    public virtual Facility? Facility { get; set; }

    public virtual Program? Program { get; set; }
}
