using Election_System.Configurations;

namespace Election_System.Generics
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        private DataContext _dataContext;

        public GenericRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public DataContext GetDataContext()
        {
            return _dataContext;
        }

        public virtual Entity GetById(int id)
        {
            return _dataContext.Set<Entity>().Find(id);
        }

        public virtual List<Entity> GetAll()
        {
            return _dataContext.Set<Entity>().ToList();
        }

        public virtual Entity Add(Entity entity)
        {
            Entity addedEntity = _dataContext.Add<Entity>(entity).Entity;
            _dataContext.SaveChanges();
            return addedEntity;
        }

        public virtual Entity Update(Entity entity)
        {
            Entity updatedEntity = _dataContext.Update<Entity>(entity).Entity;
            _dataContext.SaveChanges();
            return updatedEntity;
        }

        public virtual void DeleteById(int id)
        {
            _dataContext.Remove<Entity>(GetById(id));
            _dataContext.SaveChanges();
        }

        public virtual void DeleteByEntity(Entity entity)
        {
            _dataContext.Remove<Entity>(entity);
            _dataContext.SaveChanges();
        }

    }

}
