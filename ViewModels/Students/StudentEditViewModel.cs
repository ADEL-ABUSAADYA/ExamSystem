using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Students
{
    public class StudentEditViewModel : StudentCreateViewModel, IUpdatable
    {
        public int ID { get; set; }
        public string[] GetPropertyNames()
        {
            string[] propertyNames = { nameof(Name), nameof(Mobile), nameof(Email), nameof(Adress), nameof(Birthdate) };
            return propertyNames;
        }

        public int GetPropertyCount()
        {
            return GetPropertyNames().Count();
        }
    }
}
