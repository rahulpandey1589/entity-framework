namespace Infrastructure.Configuration.Models;

public class Subject
{
    public int Id { get; set; }
    public string SubjectName { get; set; } = default!;
    public virtual ICollection<StudentSubject> StudentSubjects{get;set;} = default!;
}


