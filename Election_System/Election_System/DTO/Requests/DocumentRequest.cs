using Election_System.Enumerations;

namespace Election_System.DTO.Requests
{
    public class DocumentRequest
    {
        public int StudentId { get; set; }
        public IFormFile File { get; set; }

    }

}
