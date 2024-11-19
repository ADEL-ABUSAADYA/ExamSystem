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

    public int Add(QuestionCreateViewModel viewModel)
    {
        // validate exam data before insertion

        var Question = new Question
        {
            Body = viewModel.Body,
            Grade = viewModel.Grade,
        };

        _QuestionRepository.Add(Question);

        _QuestionRepository.SaveChanges();


        return Question.ID;
    }

}

