using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Instrucotrs
{
    public class InstructorViewModel : IUpdatable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Adress { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; }
        public string[] GetPropertyNames()
        {
            return new string[] { "Name", "Birthdate", "Adress" };
        }

        public int GetPropertyCount()
        {
            return GetPropertyNames().Count();
        }
    }

    public static class InstructorViewModelExtenion
    {
        public static InstructorViewModel ToViewModel(this Instructor instrucotr)
        {
            return new InstructorViewModel
            {
                ID = instrucotr.ID,
                Name = instrucotr.Name,
            };
        }

        public static IQueryable<InstructorViewModel> ToViewModel(this IQueryable<Instructor> instructors)
        {
            return instructors.Select(x => new InstructorViewModel
            {
                ID = x.ID,
                Name = x.Name,
            });
        }

    }
}
