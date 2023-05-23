using Election_System.Generics;
using Election_System.Models;

namespace Election_System.Repositories
{
    public interface IAnnouncementRepository : IGenericRepository<Announcement>
    {
       public List<Announcement> GetAnnouncements();

    }

}
