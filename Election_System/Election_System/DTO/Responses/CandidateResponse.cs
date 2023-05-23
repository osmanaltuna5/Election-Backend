using Election_System.Enumerations;
using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class CandidateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public Gender? Gender { get; set; }
        public DepartmentResponse Department { get; set; }
        public ProcessType Process { get; set; }

        public CandidateResponse(Candidate candidate)
        {
            Id = candidate.CandidateStudent.Id;
            FirstName = candidate.CandidateStudent.FirstName;
            MiddleName = candidate.CandidateStudent.MiddleName;
            LastName = candidate.CandidateStudent.LastName;
            Gender = candidate.CandidateStudent.Gender;
            Department = new DepartmentResponse(candidate.CandidateStudent.Department);
            Process = candidate.ProcessType;
        }

    }

}
