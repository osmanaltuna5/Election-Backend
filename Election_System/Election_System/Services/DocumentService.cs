using Election_System.DTO.Requests;
using Election_System.DTO.Responses;
using Election_System.Models;
using Election_System.Repositories;
using Election_System.Enumerations;

namespace Election_System.Services
{
    public class DocumentService : IDocumentService
    {
        private IDocumentRepository _documentRepository;
        public DocumentService(IDocumentRepository documentRepository) 
        {
            _documentRepository = documentRepository;
        }

        public DocumentResponse AddDocumentForDepartmentRepresentative(DocumentRequest document)
        {
            Models.File newFile = null;
            long fileSize = document.File.Length;

            if (fileSize > 0)
            {
                using (var stream = new MemoryStream())
                {
                    document.File.CopyTo(stream);
                    var bytes = stream.ToArray();

                    newFile = new Models.File()
                    {
                        Name = document.File.Name,
                        Type = document.File.ContentType,
                        Content = bytes
                    };

                }
            }

            Document newDocument = new Document()
            {
                File = newFile,
                StudentId = document.StudentId,
                ControlStatus = ControlStatus.WAITING,
                ProcessType = ProcessType.DEPARTMENT_REPRESENTATIVE
            };

            int id = _documentRepository.Add(newDocument).Id;

            return new DocumentResponse(_documentRepository.GetById(id));
        }

    }

}
