using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Exams;

namespace ExaminationSystem.ViewModels.Exams;

public class ExamEditViewModel : ExamCreateViewModel, IUpdatable
{
    public int ID { get; set; }
    public string[] GetPropertyNames()
    {
        string[] propertyNames = {nameof(Date), nameof(ExamType), nameof(MaxTime), nameof(MaxNumberOfQuestions), nameof(InstructorId), nameof(QuestionsIDs)};
        return propertyNames;
    }

    public int GetPropertyCount()
    {
        return GetPropertyNames().Count();
    }
}