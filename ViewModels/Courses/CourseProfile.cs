using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Courses;

namespace ExaminationSystem;

public class CourseProfile : AutoMapper.Profile
{
    public CourseProfile()
    {
        CreateMap<CourseCreateViewModel, Course>().ReverseMap();
        CreateMap<CourseEditViewModel, Course>().ReverseMap();
        // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
        CreateMap<Course, CourseViewModel>()
            .ForMember(dest => dest.InsructorName, opt => opt.MapFrom(src => src.InstructorCourses.Select(ic => ic.Instructor.Name).FirstOrDefault()))
            .ForMember(dest => dest.StudentsEnrolled, opt => opt.MapFrom(src => src.StudentCourses.Select(sc => sc.Student.Name)))
            .ForMember(dest => dest.Groups, opt => opt.MapFrom(src => src.Groups.Select(g => g.Name)));

    }
}
