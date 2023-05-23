using Election_System.Enumerations;

namespace Election_System.Models
{
    public class Document
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public File? File { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public ControlStatus ControlStatus { get; set; }
        public ProcessType ProcessType { get; set; }

    }

}
