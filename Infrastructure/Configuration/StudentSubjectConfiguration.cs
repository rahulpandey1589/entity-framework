using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration.Models;

public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
{
    public void Configure(
        EntityTypeBuilder<StudentSubject> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).UseIdentityColumn();


        builder.HasKey(s => new {s.StudentId, s.SubjectId});

        builder.HasOne<Student>(x => x.Student)
        .WithMany(x => x.StudentSubjects)
        .HasForeignKey(x => x.StudentId);

        
        builder.HasOne<Subject>(x => x.Subject)
        .WithMany(x => x.StudentSubjects)
        .HasForeignKey(x => x.SubjectId);

    }
}
