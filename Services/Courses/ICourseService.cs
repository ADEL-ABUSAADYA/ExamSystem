using ExaminationSystem.ViewModels.Courses;

namespace ExaminationSystem.Services.Courses;

public interface ICourseService
{
    int Create(CourseCreateViewModel course);
    CourseViewModel GetById(int id);
    IQueryable<CourseViewModel> GetAll();
    CourseViewModel GetByName(string name);
    bool UpdateCourse(CourseEditViewModel courseEditViewModel);
    bool Delete(int id);
}