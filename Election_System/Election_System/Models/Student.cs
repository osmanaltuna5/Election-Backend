using Election_System.Enumerations;

namespace Election_System.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public float GPA { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<Document> Documents { get; set; }
        public List<Candidate> Candidacies { get; set; }
        public List<ElectionResult> FirstStudents { get; set; }
        public List<ElectionResult> SecondStudents { get; set; }

    }

}
