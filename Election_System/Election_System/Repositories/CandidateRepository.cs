using Election_System.Configurations;
using Election_System.Enumerations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public List<Candidate> GetAllCandidates()
        {
            return GetDataContext().candidates.
                Include(c => c.CandidateStudent).
                ThenInclude(s => s.Department).
                ThenInclude(d => d.Faculty).
                ToList();
        }

        public List<Candidate> GetCandidatesByDepartmentId(int departmentId)
        {
            return GetDataContext().candidates.
                Include(c => c.CandidateStudent).
                ThenInclude(s => s.Department).
                ThenInclude(d => d.Faculty).
                Where(c => c.CandidateStudent.DepartmentId == departmentId && c.ProcessType == ProcessType.DEPARTMENT_REPRESENTATIVE).
                ToList();
        }
    }
}
