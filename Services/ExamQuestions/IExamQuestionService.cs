using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.ExamQuestions
{
    public interface IExamQuestionService
    {
        void Add(ExamQuestionsViewModel questions);
        void AddRange(IEnumerable<ExamQuestionsViewModel> questions);
    }
}
