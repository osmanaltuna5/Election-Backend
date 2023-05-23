using Election_System.DTO.Requests;
using Election_System.DTO.Responses;

namespace Election_System.Services
{
    public interface IDocumentService
    {
        public DocumentResponse AddDocumentForDepartmentRepresentative(DocumentRequest document);

    }

}
