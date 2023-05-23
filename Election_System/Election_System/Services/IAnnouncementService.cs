using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IAnnouncementService
    {
        public List<AnnouncementResponse> GetAll();

    }

}
