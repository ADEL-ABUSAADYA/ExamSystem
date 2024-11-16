using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Instrucotrs
{
    public class InstructorEditViewModel : InstructorCreateViewModel
    {
        public int ID { get; set; }
    }
    
    public static class InstructorEditViewModelExtension
    {
        public static Instructor ToInstructorModel(InstructorEditViewModel viewModel)
        {
            var instructor = viewModel.ToModel();
            instructor.ID = viewModel.ID;

            return instructor;
        }
    }
}
