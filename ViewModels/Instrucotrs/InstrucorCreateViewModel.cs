using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Instrucotrs
{
    public class InstructorCreateViewModel
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
    }

    public static class InstructorCreateViewModelExtension
    {
        public static Instructor ToModel(this InstructorCreateViewModel viewModel)
        {
            return new Instructor
            {
                Name = viewModel.Name,
                Mobile = viewModel.Mobile,
            };
        }
    }
}
