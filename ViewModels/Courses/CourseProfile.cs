using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Courses;

namespace ExaminationSystem;

public class CourseProfile : AutoMapper.Profile
{
    public CourseProfile()
    {
        CreateMap<Course, CourseViewModel>().ReverseMap();
        CreateMap<CourseCreateViewModel, Course>().ReverseMap();
        CreateMap<CourseEditViewModel, Course>().ReverseMap();
        // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
    }
}
