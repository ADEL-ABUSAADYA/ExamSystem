using ExaminationSystem.Data;
using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instrucotrs;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class InstructorController : ControllerBase
    {
        //InstructorRepository _instructorRepository;
        IRepository<Instructor> _instructorRepository;

        public InstructorController()
        {
            _instructorRepository = new Repository<Instructor>();
        }

        [HttpPost]
        public string Create(InstructorCreateViewModel viewModel)
        {
            //Context context = new Context();

            //context.Instructors.Add(instructor);

            //context.SaveChanges();

            return "Done";
        }

        [HttpGet]
        public InstrucorViewModel GetByName(string name)
        {
            var instructor =
                _instructorRepository.Get(x => x.Name.Contains(name))
                .Select(x => new InstrucorViewModel { ID = x.ID, Name = x.Name })
                .FirstOrDefault();

            return instructor;
        }

        [HttpGet]
        public InstrucorViewModel GetByID(int id)
        {
            //var instructor =
            //    _instructorRepository.GetByID(id);

            //return instructor.ToViewModel();

            var instructor =
                _instructorRepository.Get(x => x.ID == id)
                .ToViewModel().FirstOrDefault();

            return instructor;
        }

        [HttpGet]
        public IEnumerable<InstrucorViewModel> GetAll()
        {
            // var instructors =
            //     _instructorRepository.GetAll().ToViewModel();
            //     return instructors;
            // FakeDataService fakeDataService = new FakeDataService();
            // return fakeDataService.GetData();

            return _instructorRepository.GetAll().ProjectTo<InstrucorViewModel>();
        }

        [HttpPut]
        public void Update(int id, string name)
        {
            var instructor = new Instructor { ID = id, Name = name };

            _instructorRepository.SaveInclude(instructor, nameof(Instructor.Name));
            _instructorRepository.SaveChanges();
        }

    }
}
