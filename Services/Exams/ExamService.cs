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

            _ExamQuestionService.AddRange(viewModel.QuestionsIDs.Select(x => new ExamQuestionsViewModel
                {
                    ExamID = exam.ID,
                    QuestionID = x
                }));

            return exam.ID;
        }

        public ExamViewModel GetExamByID(int id)
        {
            var exam = _ExamRepository.GetByID(id).MapFirstOrDefault<ExamViewModel>();
            return exam;
        }

        public IQueryable<ExamViewModel> GetAllExams()
        {
            var exams = _ExamRepository.GetAll().ProjectTo<ExamViewModel>();
            return exams;
        }
        public void AddRandom(ExamCreateViewModel viewModel)
        {
            //viewModel.QuestionsIDs = new List<int>();

            
        }
        public ExamViewModel GetExamByName(string name)
        {
            return  _ExamRepository.Get(x => x.Name.Contains(name)).MapFirstOrDefault<ExamViewModel>();
        }

        public bool UpdateExam(ExamEditViewModel ExamEditViewModel)
        {
            var Exam = ExamEditViewModel.Map<Exam>();
            var isSavedExam = _ExamRepository.SaveInclude(Exam, ExamEditViewModel.GetPropertyNames());
            _ExamRepository.SaveChanges();

            return isSavedExam;
        }

        public bool Delete(int id)
        {
            bool isDeleted = _ExamRepository.Delete(new Exam() { ID = id });
            _ExamRepository.SaveChanges();
            return isDeleted;
        }
    }
}
