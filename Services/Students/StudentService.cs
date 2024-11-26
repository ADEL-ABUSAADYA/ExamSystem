using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;

using ExaminationSystem.ViewModels.Students;

namespace ExaminationSystem;

public class StudentService : IStudentService
{
    IRepository<Student> _StudentRepository;
    public StudentService(IRepository<Student> StudentRepository)
    {
        _StudentRepository = StudentRepository;
    }
    public int Add(StudentCreateViewModel StudentCreateViewModel)
    {
        var Student = StudentCreateViewModel.Map<Student>();
        _StudentRepository.Add(Student);
        _StudentRepository.SaveChanges();
        return Student.ID;
    }

    public StudentViewModel GetById(int id)
    {
       return  _StudentRepository.GetByID(id).MapFirstOrDefault<StudentViewModel>();
    }

    public IQueryable<StudentViewModel> GetAll()
    {
        return _StudentRepository.GetAll().ProjectTo<StudentViewModel>();
    }
    public StudentViewModel GetByName(string name)
    {
        return  _StudentRepository.Get(x => x.Name.Contains(name)).MapFirstOrDefault<StudentViewModel>();
    }

    public bool UpdateStudent(StudentEditViewModel StudentEditViewModel)
    {
        var Student = StudentEditViewModel.Map<Student>();
        var savedStudent = _StudentRepository.SaveInclude(Student, StudentEditViewModel.GetPropertyNames());
        _StudentRepository.SaveChanges();

        return savedStudent;
    }

    public bool Delete(int id)
    {
        bool isDeleted = _StudentRepository.Delete(new Student() { ID = id });
        _StudentRepository.SaveChanges();
        return isDeleted;
    }
}
