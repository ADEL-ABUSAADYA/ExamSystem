
using ExaminationSystem.Models;

using ExaminationSystem.ViewModels.StudentCourses;
using ExaminationSystem.ViewModels.Students;

namespace ExaminationSystem;

public class StudentCoursesProfile : AutoMapper.Profile
{
    public StudentCoursesProfile()
    {
        CreateMap<StudentCourse, StudentCoursesViewModel>()
            .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name)) // Example
            .ForMember(dest => dest.StudentName, opt => opt.MapFrom(src => src.Student.Name)); // Example
    }
}
