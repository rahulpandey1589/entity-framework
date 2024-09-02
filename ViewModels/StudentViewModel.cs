namespace EntityFramework.ViewModels
{
    public class StudentViewModel
    {
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string RollNumber { get; set; } = default!;

        public List<int> SubjectId { get; set; } = default!;
    }
}