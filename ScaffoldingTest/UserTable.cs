using System;
using System.Collections.Generic;

namespace ScaffoldingTest;

public partial class UserTable
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? ProgramEnrolledIn { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime LastModified { get; set; }

    public string AspNetUsersId { get; set; } = null!;

    public int? InstructorId { get; set; }

    public virtual AspNetUser AspNetUsers { get; set; } = null!;

    public virtual UserTable? Instructor { get; set; }

    public virtual ICollection<UserTable> InverseInstructor { get; set; } = new List<UserTable>();

    public virtual ICollection<Request> RequestCompletedByNavigations { get; set; } = new List<Request>();

    public virtual ICollection<Request> RequestEnteredByNavigations { get; set; } = new List<Request>();

    public virtual ICollection<UserFacility> UserFacilities { get; set; } = new List<UserFacility>();

    public virtual ICollection<UserSecurityQuestion> UserSecurityQuestions { get; set; } = new List<UserSecurityQuestion>();

    public virtual ICollection<Program> Programs { get; set; } = new List<Program>();
}
