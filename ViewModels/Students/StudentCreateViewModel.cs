using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Students
{
    public class StudentCreateViewModel
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }
    }
}
