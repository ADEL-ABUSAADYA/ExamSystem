using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.ExamQuestions;
using ExaminationSystem.ViewModels.Questions;

namespace ExaminationSystem;

public class QuestionService : IQuestionService
{
    IRepository<Question> _QuestionRepository;
    IRepository<Answer> _AnswerRepository;

    public QuestionService(IRepository<Question> QuestionRepository, IRepository<Answer> AnswerRepository)
    {
        _QuestionRepository = QuestionRepository;
        _AnswerRepository = AnswerRepository;
    }

    public int Add(QuestionCreateViewModel questionCreateViewModel)
    {
        var newQuestion = questionCreateViewModel.Map<Question>();
        _QuestionRepository.Add(newQuestion);
        _QuestionRepository.SaveChanges();
        foreach (var answer in newQuestion.Answers)
        {
            _AnswerRepository.Add(answer);
        }

        return newQuestion.ID;
    }

    public QuestionViewModel GetQuestionByID(int id)
    {
        var question = _QuestionRepository.GetByID(id).MapFirstOrDefault<QuestionViewModel>();
        return question;
    }

    public bool UpdateQuestion(QuestionEditViewModel model)
    {
        var question = model.Map<Question>();
        var isUpdatedquestion = _QuestionRepository.SaveInclude(question, model.GetPropertyNames());
        _QuestionRepository.SaveChanges();
        return isUpdatedquestion;
    }

    public bool DeleteQuestion(int id)
    {
        bool isDeleted = _QuestionRepository.Delete(new Question { ID = id });
        _QuestionRepository.SaveChanges();
        return isDeleted;
    }
}

