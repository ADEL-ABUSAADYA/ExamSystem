using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public class InstructorProfile : Profile
{
    public InstructorProfile(){
        CreateMap<Instructor, InstrucorViewModel>()
        .ForMember(dst => dst.Adress, ops => ops.MapFrom(src => "fgh"));
        CreateMap<InstructorCreateViewModel, Instructor>();
        // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
    }
}
