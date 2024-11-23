namespace ExaminationSystem.Services.GenaricService;

public interface IService<E,IVM>
{
    int Add(IVM creatViewModel);
    IVM GetById(int id);
    IQueryable<E> GetAll();
    IVM GetByName(string name);
    bool Update(IVM EditViewModel);
    bool Delete(int id);
}