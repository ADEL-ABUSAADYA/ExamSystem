using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public interface IInstructorService
{
    int Add(InstructorCreateViewModel instrucorViewModel);
    InstructorViewModel GetById(int id);
    IQueryable<InstructorViewModel> GetAll();
    InstructorViewModel GetByName(string name);
    InstructorViewModel UpdateInstructor(InstructorEditViewModel instructorEditViewModel);
    bool Delete(Instructor instructor);
}
