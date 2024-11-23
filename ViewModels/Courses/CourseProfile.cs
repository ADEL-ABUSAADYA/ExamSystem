using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Courses;

namespace ExaminationSystem;

public class CourseProfile : AutoMapper.Profile
{
    public CourseProfile()
    {
        CreateMap<Course, CourseViewModel>();
        CreateMap<CourseCreateViewModel, Course>();
        CreateMap<CourseEditViewModel, Course>();
        // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
    }
}
