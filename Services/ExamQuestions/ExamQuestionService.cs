using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.ExamQuestions
{
    public class ExamQuestionService : IExamQuestionService
    {
        IRepository<Models.ExamQuestions> _ExamQuestionRepository;

        public ExamQuestionService(IRepository<Models.ExamQuestions> ExamQuestionRepository)
        {
            _ExamQuestionRepository = ExamQuestionRepository;
        }

        public void Add(ExamQuestionCreateViewModel viewModel)
        {
            _ExamQuestionRepository.Add(new Models.ExamQuestions
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
                _ExamQuestionRepository.Add(new Models.ExamQuestions
                {
                    ExamID = viewModel.ExamID,
                    QuestionID = viewModel.QuestionID,
                });
            }

            _ExamQuestionRepository.SaveChanges();
        }
    }
}
