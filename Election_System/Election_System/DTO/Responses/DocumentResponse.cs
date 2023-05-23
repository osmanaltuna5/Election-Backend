using Election_System.Enumerations;
using Election_System.Models;

namespace Election_System.DTO.Responses
{
    public class DocumentResponse
    {
        public int Id { get; set; }
        public FileResponse File { get; set; }
        public ControlStatus ControlStatus { get; set; }
        public ProcessType Process { get; set; }

        public DocumentResponse(Document document)
        {
            Id = document.Id;
            File = new FileResponse(document.File);
            ControlStatus = document.ControlStatus;
            Process = document.ProcessType;
        }

    }

}
