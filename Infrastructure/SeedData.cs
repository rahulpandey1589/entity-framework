using Infrastructure.Configuration.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration;

public class SeedData
{

    public void SeedSubjectData(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Subject>().HasData(
            new List<Subject>()
            {
                new Subject(){
                      Id = 1,
                      SubjectName="Maths"
                },
                new Subject(){
                      Id = 2,
                      SubjectName="SST"
                },
                new Subject(){
                       Id = 3,
                      SubjectName="Hindi"
                },
                new Subject(){
                      Id = 4,
                      SubjectName="English"
                },
                new Subject(){
                    Id = 5,
                    SubjectName="Science"
                }
            });
    }

}