using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Repositories
{
    public class ProcessRepository : GenericRepository<Process>, IProcessRepository
    {
        public ProcessRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public override List<Process> GetAll()
        {
            return GetDataContext().processes.
                Where(a => DateTime.Compare(a.StartDate, DateTime.Now.Date) < 0 && DateTime.Compare(a.EndDate, DateTime.Now.Date) > 0).
                ToList();
        }

    }

    
}
