using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.ExamQuestions;

namespace ExaminationSystem;

public class QuestionService : IQuestionService
{
    IRepository<Question> _QuestionRepository;
    IExamQuestionService _ExamQuestionService;

    public QuestionService(IRepository<Question> QuestionRepository, IExamQuestionService ExamQuestionService)
    {
        _QuestionRepository = QuestionRepository;
        _ExamQuestionService = ExamQuestionService;
    }

    public int Add(QuestionCreateViewModel questionCreateViewModel)
    {
        var newQuestion = questionCreateViewModel.Map<Question>();
        _QuestionRepository.Add(newQuestion);
        _QuestionRepository.SaveChanges();
        return newQuestion.ID;
    }

}

