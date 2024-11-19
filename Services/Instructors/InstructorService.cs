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
    public void Add(InstructorCreateViewModel instructorCreateViewModel)
    {
        var instructor = instructorCreateViewModel.Map<Instructor>();
        _InstructorRepository.Add(instructor);
        _InstructorRepository.SaveChanges();
    }

    public InstrucorViewModel GetById(int id)
    {
       return  _InstructorRepository.GetByID(id).MapFirstOrDefault<InstrucorViewModel>();
    }

    public IQueryable<InstrucorViewModel> GetAll()
    {
        return _InstructorRepository.GetAll().ProjectTo<InstrucorViewModel>();
    }
}
