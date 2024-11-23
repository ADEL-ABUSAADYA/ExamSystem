using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public class InstructorProfile : AutoMapper.Profile
{
    public InstructorProfile()
    {
        // Assuming you want to map from Instructor to InstructorViewModel
        CreateMap<Instructor, InstructorCreateViewModel>().ReverseMap();
        CreateMap<Instructor, InstructorViewModel>();
            // .IncludeBase<Instructor, BaseViewModel>();

        // Assuming BaseViewModel is a parent class of InstructorViewModel
        // CreateMap<Instructor, BaseViewModel>()
        //     .IncludeBase<Instructor, InstructorViewModel>();
        // // CreateMap<Instructor, BaseViewModel>().IncludeBase<Instructor, InstructorViewModel>();
        // // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
    }
}
