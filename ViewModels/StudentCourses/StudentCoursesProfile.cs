
using ExaminationSystem.Models;

using ExaminationSystem.ViewModels.StudentCourses;
using ExaminationSystem.ViewModels.Students;

namespace ExaminationSystem;

public class StudentCoursesProfile : AutoMapper.Profile
{
    public StudentCoursesProfile()
    {
        CreateMap<StudentCourse, StudentCreateViewModel>().ReverseMap();
    }
}
