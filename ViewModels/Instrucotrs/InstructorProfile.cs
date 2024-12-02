using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Courses;
using ExaminationSystem.ViewModels.Instrucotrs;
using ExaminationSystem.ViewModels.InstructorCourses;

namespace ExaminationSystem;

public class InstructorProfile : AutoMapper.Profile
{
    public InstructorProfile()
    {
        // Assuming you want to map from Instructor to InstructorViewModel
        CreateMap<Instructor, InstructorViewModel>()
        .ForMember(dest => dest.InstructorCourses, opt => opt.MapFrom(src => src.InstructorCourses.Select(ic => ic.Course.Name)));
    //
    }
}
