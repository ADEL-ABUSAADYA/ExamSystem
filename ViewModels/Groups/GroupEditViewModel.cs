using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Groups
{
    public class GroupEditViewModel : GroupCreateViewModel , IUpdatable
    {
        public int ID { get; set; }
        public string[] GetPropertyNames()
        {
            string[] propertyNames = {nameof(Name), nameof(InstructorID), nameof(CourseID)};
            return propertyNames;
        }

        public int GetPropertyCount()
        {
            return GetPropertyNames().Count();
        }
    }
    
}
