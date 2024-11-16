using System.Numerics;
using ExaminationSystem.Models;

namespace ExaminationSystem;

public class QuestionCreateViewModel
{
    public string Body { get; set; }
    public int Grade { get; set; }
}

public static class QuestionCreateViewModelExtension
    {
        public static Question ToModel(this QuestionCreateViewModel viewModel)
        {
            return new Question
            {
                Body = viewModel.Body,
                Grade = viewModel.Grade,
            };
        }
    }
