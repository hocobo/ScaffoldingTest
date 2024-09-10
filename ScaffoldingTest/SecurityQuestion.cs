using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class SecurityQuestion
{
    public int SecurityQuestionId { get; set; }

    public string QuestionText { get; set; } = null!;

    public virtual ICollection<UserSecurityQuestion> UserSecurityQuestions { get; set; } = new List<UserSecurityQuestion>();
}
