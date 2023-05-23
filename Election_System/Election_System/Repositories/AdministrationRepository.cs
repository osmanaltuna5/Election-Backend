using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public class AdministrationRepository : GenericRepository<Administration>, IAdministrationRepository
    {
        public AdministrationRepository(DataContext dataContext) : base(dataContext)
        {
            
        }

    }

}
