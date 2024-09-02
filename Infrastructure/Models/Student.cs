namespace Infrastructure.Configuration.Models;

public class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = default!;

    public string LastName { get; set; } = default!;

    public string RollNumber { get; set; } = default!;

    public virtual ICollection<StudentSubject> StudentSubjects{get;set;} = default!;
}


