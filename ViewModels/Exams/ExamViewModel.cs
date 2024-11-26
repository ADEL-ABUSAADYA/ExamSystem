using ExaminationSystem.Models;
using ExaminationSystem.Models.Enums;
using ExaminationSystem.ViewModels.Exams;
using ExaminationSystem.ViewModels.Instrucotrs;
using ExaminationSystem.ViewModels.InstructorCourses;
using ExaminationSystem.ViewModels.StudentCourses;

namespace ExaminationSystem.ViewModels.Exams;

public class ExamViewModel
{
    
    public int MaxNumberOfQuestions { get; set; }
    public int MaxTime { get; set; }
    public DateTime Date { get; set; }
    public ExamType ExamType { get; set; }

    public int InstructorId { get; set; }
    public ICollection<ExamQuestionsViewModel> ExamQuestions { get; set; }
    public ICollection<StudentExam> ExamAssignments { get; set; }
    
}