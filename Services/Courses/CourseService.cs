using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.ViewModels.Courses;

namespace ExaminationSystem;

public class CourseService : ICourseService
{
    IRepository<Course> _CourseRepository;
    public CourseService(IRepository<Course> CourseRepository)
    {
        _CourseRepository = CourseRepository;
    }
    public int Create(CourseCreateViewModel courseCreateViewModel)
    {
        var course = courseCreateViewModel.Map<Course>();
        _CourseRepository.Add(course);
        _CourseRepository.SaveChanges();
        return course.ID;
    }

    public CourseViewModel GetById(int id)
    {
       return  _CourseRepository.GetByID(id).MapFirstOrDefault<CourseViewModel>();
    }

    public IQueryable<CourseViewModel> GetAll()
    {
        return _CourseRepository.GetAll().ProjectTo<CourseViewModel>();
    }
    public CourseViewModel GetByName(string name)
    {
        return  _CourseRepository.Get(x => x.Name.Contains(name)).MapFirstOrDefault<CourseViewModel>();
    }

    public bool UpdateCourse(CourseEditViewModel courseEditViewModel)
    {
        var course = courseEditViewModel.Map<Course>();
        var savedCourse = _CourseRepository.SaveInclude(course, courseEditViewModel.GetPropertyNames());
        _CourseRepository.SaveChanges();

        return savedCourse;
    }

    public bool Delete(int id)
    {
        bool isDeleted = _CourseRepository.Delete(new Course() { ID = id });
        _CourseRepository.SaveChanges();
        return isDeleted;
    }
}
