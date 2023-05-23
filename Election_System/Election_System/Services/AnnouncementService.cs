using Election_System.DTO;
using Election_System.DTO.Responses;
using Election_System.Repositories;
using Microsoft.Identity.Client;

namespace Election_System.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IAnnouncementRepository _announcementRepository;
        public  AnnouncementService(IAnnouncementRepository announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }

        public List<AnnouncementResponse> GetAll()
        {   
            List<AnnouncementResponse> announcementResponses = new List<AnnouncementResponse>();
            foreach (var announcement in _announcementRepository.GetAnnouncements())
            {
                announcementResponses.Add(new AnnouncementResponse(announcement));

            }

           return announcementResponses;
        }

    }
}
