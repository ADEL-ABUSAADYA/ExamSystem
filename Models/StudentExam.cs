namespace ExaminationSystem.Models;

public class StudentExam
{
    public int ID { get; set; }
    public bool IsCompleted { get; set; }
    public int Score { get; set; }
    public string Message { get; set; }

    // Foreign Keys
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int ExamId { get; set; }
    public Exam Exam { get; set; }
}