using Election_System.Configurations;
using Election_System.Generics;
using Election_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Election_System.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(DataContext dataContext) : base(dataContext)
        {

        }

        public override List<Student> GetAll()
        {
            return GetDataContext().students.
                Include(s => s.Department).
                ThenInclude(d => d.Faculty).
                ToList();
        }

        public override Student GetById(int id)
        {
            return GetDataContext().students.
                Where(s => s.Id == id).
                Include(s => s.Department).
                ThenInclude(d => d.Faculty).
                FirstOrDefault();
        }

    }

}
