using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.ExamQuestions
{
    public class ExamQuestionService : IExamQuestionService
    {
        IRepository<ExamQuestion> _ExamQuestionRepository;

        public ExamQuestionService(IRepository<ExamQuestion> ExamQuestionRepository)
        {
            _ExamQuestionRepository = ExamQuestionRepository;
        }

        public void Add(ExamQuestionCreateViewModel viewModel)
        {
            _ExamQuestionRepository.Add(new ExamQuestion
            {
                ExamID = viewModel.ExamID,
                QuestionID = viewModel.QuestionID,
            });

            _ExamQuestionRepository.SaveChanges();
        }

        public void AddRange(IEnumerable<ExamQuestionCreateViewModel> viewModels)
        {
            foreach (var viewModel in viewModels)
            {
                _ExamQuestionRepository.Add(new ExamQuestion
                {
                    ExamID = viewModel.ExamID,
                    QuestionID = viewModel.QuestionID,
                });
            }

            _ExamQuestionRepository.SaveChanges();
        }
    }
}
