using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public interface IInstructorService
{
    void Add(InstructorCreateViewModel instrucorViewModel);
    InstrucorViewModel GetById(int id);
    IQueryable<InstrucorViewModel> GetAll();
}
