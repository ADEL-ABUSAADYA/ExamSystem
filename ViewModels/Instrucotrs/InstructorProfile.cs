using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;

namespace ExaminationSystem;

public class InstructorProfile : Profile
{
    public InstructorProfile(){
        CreateMap<Instructor, InstrucorViewModel>()
        .ForMember(dst => dst.Adress, ops => ops.MapFrom(src => "sdsd"));
        CreateMap<Instructor, InstructorCreateViewModel>();
    }
}
