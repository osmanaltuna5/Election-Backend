using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface ICandidateService
    {
        public List<CandidateResponse> GetAll();
        public List<CandidateResponse> GetCandidatesByDepartmentId(int id);
    }
}
