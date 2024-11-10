using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Instrucotrs
{
    public class InstrucorViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public static class InstructorViewModelExtenion
    {
        public static InstrucorViewModel ToViewModel(this Instructor instrucotr)
        {
            return new InstrucorViewModel
            {
                ID = instrucotr.ID,
                Name = instrucotr.Name,
            };
        }

        public static IQueryable<InstrucorViewModel> ToViewModel(this IQueryable<Instructor> instructors)
        {
            return instructors.Select(x => new InstrucorViewModel
            {
                ID = x.ID,
                Name = x.Name,
            });
        }

    }
}
