using Election_System.Enumerations;

namespace Election_System.Models
{
    public class Administration
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<Process> Processes { get; set; }

    }

}
