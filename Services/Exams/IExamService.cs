
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.Exams
{
    public interface IExamService
    {
        int Add(ExamCreateViewModel model);
        ExamViewModel GetExamByID(int id);
        IQueryable<ExamViewModel> GetAllExams();
        ExamViewModel GetExamByName(string name);
        bool UpdateExam(ExamEditViewModel EditViewModel);
        bool Delete(int id);
    }
}
