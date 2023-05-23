using Election_System.Enumerations;
using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class StudentResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }
        public float GPA { get; set; }
        public DepartmentResponse Department { get; set; }

        public StudentResponse(Student student) 
        {
            Id = student.Id;
            Username = student.Username;
            Role = student.Role;
            FirstName = student.FirstName;
            MiddleName = student.MiddleName;
            LastName = student.LastName;
            Gender = student.Gender;
            GPA = student. GPA;
            Department = new DepartmentResponse(student.Department);
        }

    }

}
