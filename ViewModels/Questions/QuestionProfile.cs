using AutoMapper;
using ExaminationSystem.Models;

using ExaminationSystem.ViewModels.Questions;


namespace ExaminationSystem;

public class QuestionProfile : AutoMapper.Profile
{
    public QuestionProfile()
    {
        CreateMap<Question, QuestionCreateViewModel>().ReverseMap();
        CreateMap<Question, QuestionEditViewModel>().ReverseMap();
        CreateMap<Question, QuestionViewModel>();

    }
}
