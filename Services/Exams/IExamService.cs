using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.Services.Exams
{
    public interface IExamService
    {
        int Add(ExamCreateViewModel model);

        // ExamViewModel GetByID(int id);
    }
}
