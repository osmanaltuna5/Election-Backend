using Election_System.Enumerations;

namespace Election_System.Models
{
    public class Process
    {
        public int Id { get; set; }
        public ProcessType ProcessType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? AdministratonId { get; set; }
        public Administration? administration { get; set; }

    }

}
