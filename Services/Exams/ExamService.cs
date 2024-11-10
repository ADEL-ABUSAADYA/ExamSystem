using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.ExamQuestions;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.Exams
{
    public class ExamService : IExamService
    {
        IRepository<Exam> _examRepository;
        IExamQuestionService _ExamQuestionService;

        public ExamService()
        {
            _examRepository = new Repository<Exam>();
            _ExamQuestionService = new ExamQuestionService();
        }

        public int Add(ExamCreateViewModel viewModel)
        {
            // validate exam data before insertion

            var exam = new Exam
            {
                Date = viewModel.Date,
                MaxGrade = viewModel.MaxGrade,
                MaxTime = viewModel.MaxTime,
            };

            _examRepository.Add(exam);

            _examRepository.SaveChanges();

            _ExamQuestionService.AddRange(viewModel.QuestionsIDs
                .Select(x => new ExamQuestionCreateViewModel
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
