using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Students;

namespace ExaminationSystem;

public interface IStudentService
{
    int Add(StudentCreateViewModel studentCreateView);
    StudentViewModel GetById(int id);
    IQueryable<StudentViewModel> GetAll();
    StudentViewModel GetByName(string name);
    bool UpdateStudent(StudentEditViewModel studentEditViewModel);
    bool Delete(int id);
}
