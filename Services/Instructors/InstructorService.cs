using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public class InstructorService : IInstructorService
{
    IRepository<Instructor> _InstructorRepository;
    public InstructorService(IRepository<Instructor> InstructorRepository)
    {
        _InstructorRepository = InstructorRepository;
    }
    public int Add(InstructorCreateViewModel instructorCreateViewModel)
    {
        var instructor = instructorCreateViewModel.Map<Instructor>();
        _InstructorRepository.Add(instructor);
        _InstructorRepository.SaveChanges();
        return instructor.ID;
    }

    public InstructorViewModel GetById(int id)
    {
       return  _InstructorRepository.GetByID(id).MapFirstOrDefault<InstructorViewModel>();
    }

    public IQueryable<InstructorViewModel> GetAll()
    {
        return _InstructorRepository.GetAll().ProjectTo<InstructorViewModel>();
    }
    public InstructorViewModel GetByName(string name)
    {
        return  _InstructorRepository.Get(x => x.Name.Contains(name)).MapFirstOrDefault<InstructorViewModel>();
    }

    public bool UpdateInstructor(InstructorEditViewModel instructorEditViewModel)
    {
        var instructor = instructorEditViewModel.Map<Instructor>();
        var savedInstructor = _InstructorRepository.SaveInclude(instructor, instructorEditViewModel.GetPropertyNames());
        _InstructorRepository.SaveChanges();

        return savedInstructor;
    }

    public bool Delete(int id)
    {
        bool isDeleted = _InstructorRepository.Delete(new Instructor() { ID = id });
        _InstructorRepository.SaveChanges();
        return isDeleted;
    }
}
