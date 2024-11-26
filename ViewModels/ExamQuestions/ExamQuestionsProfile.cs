using AutoMapper;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem;

public class ExamQuestionsProfile : AutoMapper.Profile
{
    public ExamQuestionsProfile()
    {
        CreateMap<ExamQuestion, ExamQuestionsViewModel>().ReverseMap();
    }
}
