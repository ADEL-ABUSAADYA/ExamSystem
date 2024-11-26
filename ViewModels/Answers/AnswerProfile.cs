
using ExaminationSystem.Models;

using ExaminationSystem.ViewModels.Answers;

namespace ExaminationSystem;

public class AnswerProfile : AutoMapper.Profile
{
    public AnswerProfile()
    {
        CreateMap<Answer, AnswerViewModel>().ReverseMap();
    }
}
