using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels;

namespace ExaminationSystem.Services.GenaricService;

public class Service<E, IVM> : IService<E,IVM> where E : BaseModel, new() where IVM : BaseViewModel
{
    IRepository<E> _Repository;
    
    public Service(IRepository<E> Repository)
    {
        _Repository = Repository;
    }
    
    public int Add(IVM CreateViewModel)
    {
        var entity = CreateViewModel.Map<E>();
        _Repository.Add(entity);
        _Repository.SaveChanges();
        return entity.ID;
    }

    public IVM GetById(int id)
    {
        return  _Repository.GetByID(id).MapFirstOrDefault<IVM>();
    }

    public IQueryable<E> GetAll()
    {
        return _Repository.GetAll();
    }
    
    public IVM GetByName(string name)
    {
        var entity = _Repository.Get(x => x.GetType().GetProperty("Name").GetValue(x).ToString().Contains(name)).FirstOrDefault();
        return entity?.Map<IVM>();
    }

    public bool Update(IVM EditViewModel)
    {
        var entity = EditViewModel.Map<E>();
        var saved = _Repository.SaveInclude(entity, EditViewModel.GetPropertyNames());
        _Repository.SaveChanges();

        return saved;
    }

    public bool Delete(int id)
    {
        bool isDeleted = _Repository.Delete(new E() { ID = id });
        _Repository.SaveChanges();
        return isDeleted;
    }
}