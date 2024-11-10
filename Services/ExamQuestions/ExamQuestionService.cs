using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.ExamQuestions
{
    public class ExamQuestionService : IExamQuestionService
    {
        IRepository<ExamQuestion> _examQuestionRepository;

        public ExamQuestionService()
        {
            _examQuestionRepository = new Repository<ExamQuestion>();
        }

        public void Add(ExamQuestionCreateViewModel viewModel)
        {
            _examQuestionRepository.Add(new ExamQuestion
            {
                ExamID = viewModel.ExamID,
                QuestionID = viewModel.QuestionID,
            });

            _examQuestionRepository.SaveChanges();
        }

        public void AddRange(IEnumerable<ExamQuestionCreateViewModel> viewModels)
        {
            foreach (var viewModel in viewModels)
            {
                _examQuestionRepository.Add(new ExamQuestion
                {
                    ExamID = viewModel.ExamID,
                    QuestionID = viewModel.QuestionID,
                });
            }

            _examQuestionRepository.SaveChanges();
        }
    }
}
