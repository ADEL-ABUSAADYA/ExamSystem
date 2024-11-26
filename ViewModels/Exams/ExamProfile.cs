using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Courses;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem;

public class ExamProfile : AutoMapper.Profile
{
    public ExamProfile()
    {
        CreateMap<Exam, ExamViewModel>().ReverseMap();
        CreateMap<ExamCreateViewModel, Exam>().ReverseMap();
        CreateMap<ExamEditViewModel, Exam>().ReverseMap();
        // .ForMember(dest => dest.Birthdate, ops => ops.MapFrom(src => DateTime.Parse(src.Birthdate)));
    }
}
