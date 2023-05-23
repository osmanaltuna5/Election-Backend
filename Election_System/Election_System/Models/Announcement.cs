namespace Election_System.Models
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? AdministrationId { get; set; }
        public Administration? Administration { get; set; }

    }

}
