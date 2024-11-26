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

        public void Add(ExamQuestionsViewModel viewModel)
        {
            var newExamQuestion = viewModel.Map<ExamQuestion>();
            _ExamQuestionRepository.Add(newExamQuestion);
            _ExamQuestionRepository.SaveChanges();
        }

        public void AddRange(IEnumerable<ExamQuestionsViewModel> viewModels)
        {
            foreach (var viewModel in viewModels)
            {
                _ExamQuestionRepository.Add(viewModel.Map<ExamQuestion>());
            }

            _ExamQuestionRepository.SaveChanges();
        }
    }
}
