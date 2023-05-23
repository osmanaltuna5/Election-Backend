using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Models;
using Election_System.Repositories;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public class ElectionService : IElectionService
    {
        private IElectionRepository _electionRepository;
        private IStudentRepository _studentRepository;
        public ElectionService(IElectionRepository electionRepository, IStudentRepository studentRepository)
        {
            _electionRepository = electionRepository;
            _studentRepository = studentRepository;
        }

        public StudentResponse AddVoteForDepartmentRepresentative(VoteOfDepartmentRepresentativeRequest vote)
        {
            ElectionResult addedElection = new ElectionResult()
            {
                VoterStudentId = vote.VoterStudentId,
                CandidateStudentId = vote.CandidateStudentId,
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE
            };

            ElectionResult savedElection = _electionRepository.Add(addedElection);

            return new StudentResponse(_studentRepository.GetById((int) savedElection.CandidateStudentId));
        }

        public List<ElectionResultResponse> GetElectionResultsForDepartmentRepresentative(int departmentId)
        {
            List<ElectionResultResponse> electionResults = new List<ElectionResultResponse>();
            foreach (var es in _electionRepository.GetElectionResultsForDepartmentRepresentative(departmentId))
            {
                es.Candidate = new StudentResponse(_studentRepository.GetById(es.CandidateStudentId));
                electionResults.Add(es);
            }

            return electionResults;
        }

        public StudentResponse GetCandidateForDepartmentRepresentative(int voterId)
        {
            ElectionResult electionResult = _electionRepository.GetElectionResultForDepartmentRepresenatative(voterId);
            if (electionResult != null)
            {
                return new StudentResponse(electionResult.CandidateStudent);
            }

            return null;
        }

    }

}
