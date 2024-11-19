using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.ExamQuestions;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.Exams
{
    public class ExamService : IExamService
    {
        IRepository<Exam> _ExamRepository;
        IExamQuestionService _ExamQuestionService;

        public ExamService(IRepository<Exam> ExamRepository, IExamQuestionService ExamQuestionService)
        {
            _ExamRepository = ExamRepository;
            _ExamQuestionService = ExamQuestionService;
        }

        public int Add(ExamCreateViewModel viewModel)
        {
            // validate exam data before insertion

            var exam = viewModel.Map<Exam>();

            _ExamRepository.Add(exam);

            _ExamRepository.SaveChanges();

            _ExamQuestionService.AddRange(viewModel.QuestionsIDs.Select(x => new ExamQuestionCreateViewModel
                {
                    ExamID = exam.ID,
                    QuestionID = x
                }));

            return exam.ID;
        }

        public void AddRandom(ExamCreateViewModel viewModel)
        {
            //viewModel.QuestionsIDs = new List<int>();

            //Add(viewModel);
        }
    }
}
