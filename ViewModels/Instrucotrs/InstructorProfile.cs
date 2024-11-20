using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public class InstructorProfile : Profile
{
    public InstructorProfile()
    {
        CreateMap<Instructor, InstructorViewModel>();
        CreateMap<InstructorCreateViewModel, Instructor>();
        CreateMap<InstructorEditViewModel, Instructor>();
        // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
    }
}
