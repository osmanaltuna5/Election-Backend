using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        public List<Candidate> GetAllCandidates();
        public List<Candidate> GetCandidatesByDepartmentId(int departmentId);

    }
}
