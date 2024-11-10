namespace ExaminationSystem.ViewModels.Exams
{
    public class ExamCreateViewModel
    {
        public int MaxGrade { get; set; }
        public int MaxTime { get; set; }
        public DateTime Date { get; set; }

        public ICollection<int> QuestionsIDs { get; set; }
    }
}
