using Election_System.DTO.Requests;
using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IElectionService
    {
        public StudentResponse AddVoteForDepartmentRepresentative(VoteOfDepartmentRepresentativeRequest vote);
        public List<ElectionResultResponse> GetElectionResultsForDepartmentRepresentative(int departmentId);
        public StudentResponse GetCandidateForDepartmentRepresentative(int candidateId);

    }

}
