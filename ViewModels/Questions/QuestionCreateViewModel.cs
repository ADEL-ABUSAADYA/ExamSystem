using System.Numerics;
using ExaminationSystem.Models;
using ExaminationSystem.Models.Enums;

namespace ExaminationSystem;

public class QuestionCreateViewModel
{
    public string Body { get; set; }
    public int Mark { get; set; }
    public QuestionLevel Level { get; set; }
    
    public ICollection<Answer> Answers { get; set; }
}

