using Election_System.Enumerations;

namespace Election_System.Models
{
    public class ElectionResult
    {
        public int Id { get; set; }
        public int? VoterStudentId { get; set; }
        public Student? VoterStudent { get; set; }
        public int? CandidateStudentId { get; set; }
        public Student? CandidateStudent { get; set; }
        public ProcessType ProcessType { get; set; }

    }

}
