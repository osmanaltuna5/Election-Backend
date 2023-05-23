using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class DepartmentResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FacultyResponse Faculty { get; set; }

        public DepartmentResponse(Department department)
        {
            Id = department.Id;
            Name = department.Name;
            Faculty = new FacultyResponse(department.Faculty);
        }

    }

}
