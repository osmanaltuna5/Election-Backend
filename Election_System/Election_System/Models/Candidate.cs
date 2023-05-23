using Election_System.Enumerations;

namespace Election_System.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public int? CandidateStudentId { get; set; }
        public Student? CandidateStudent { get; set; }
        public ProcessType ProcessType { get; set; }

    }

}
