namespace Infrastructure.Configuration.Models;

public class StudentSubject
{
    public int Id { get; set; }

    public int StudentId { get; set; }
    public virtual Student Student{get;set;} = default!;

    public int SubjectId { get; set; }
    public virtual Subject Subject{get;set;} = default!;
}


