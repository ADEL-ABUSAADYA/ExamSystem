using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Questions
{
    public class QuestionEditViewModel : QuestionCreateViewModel, IUpdatable
    {
        public int ID { get; set; }
        public string[] GetPropertyNames()
        {
            string[] propertyNames = {nameof(Body), nameof(Mark), nameof(Level), nameof(Answers)};
            return propertyNames;
        }

        public int GetPropertyCount()
        {
            return GetPropertyNames().Count();
        }
    }
}
