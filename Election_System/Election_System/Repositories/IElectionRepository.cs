using Election_System.DTO.Responses;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface IElectionRepository : IGenericRepository<ElectionResult>
    {
        public List<ElectionResultResponse> GetElectionResultsForDepartmentRepresentative(int departmentId);
        public ElectionResult GetElectionResultForDepartmentRepresenatative(int voterId);

    }

}
