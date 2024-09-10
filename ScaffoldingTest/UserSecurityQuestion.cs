using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class UserSecurityQuestion
{
    public int UserId { get; set; }

    public int SecurityQuestionId { get; set; }

    public string AnswerHash { get; set; } = null!;

    public virtual SecurityQuestion SecurityQuestion { get; set; } = null!;

    public virtual UserTable User { get; set; } = null!;
}
