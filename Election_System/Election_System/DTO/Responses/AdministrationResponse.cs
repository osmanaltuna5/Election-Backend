using Election_System.Enumerations;
using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class AdministrationResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }

        public AdministrationResponse(Administration administration) 
        { 
            Id = administration.Id;
            Username = administration.Username;
            Role = administration.Role;
            FirstName = administration.FirstName;
            MiddleName = administration.MiddleName;
            LastName = administration.LastName;
            Gender = administration.Gender;
        }

    }
}
