using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Repositories
{
    public class DocumentRepository : GenericRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(DataContext dataContext) : base(dataContext) 
        {

        }

        public override Document GetById(int id)
        {
            return GetDataContext().documents.
                Where(d => d.Id == id).
                Include(d => d.File).
                FirstOrDefault();
        }

    }

}
