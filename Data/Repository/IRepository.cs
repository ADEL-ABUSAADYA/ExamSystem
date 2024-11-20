using System.Linq.Expressions;

namespace ExaminationSystem.Data.Repository
{
    public interface IRepository<Entity>
    {
        void Add(Entity entity);
        bool SaveInclude(Entity entity, params string[] properties);
        bool Delete(Entity entity);
        void HardDelete(Entity entity);
        IQueryable<Entity> GetAll();
        IQueryable<Entity> GetAllWithDeleted();
        IQueryable<Entity> Get(Expression<Func<Entity, bool>> predicate);
        IQueryable<Entity> GetByID(int id);
        void SaveChanges();
    }
}
