using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class FacultyResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FacultyResponse(Faculty faculty) 
        { 
            Id = faculty.Id;
            Name = faculty.Name;
        }

    }

}
