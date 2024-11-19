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
        IInstructorService _InstructorService;

        public InstructorController(IInstructorService InstructorService)
        {
            _InstructorService = InstructorService;
        }

        [HttpPost]
        public string Create(InstructorCreateViewModel viewModel)
        {
            _InstructorService.Add(viewModel);
            

            return "Done";
        }

        // [HttpGet]
        // public InstrucorViewModel GetByName(string name)
        // {
        //     var instructor =
        //         _InstructorService.Get(x => x.Name.Contains(name))
        //         .Select(x => new InstrucorViewModel { ID = x.ID, Name = x.Name })
        //         .FirstOrDefault();

        //     return instructor;
        // }

        [HttpGet]
        public InstrucorViewModel GetByID(int id)
        {
            //var instructor =
            //    _instructorRepository.GetByID(id);

            //return instructor.ToViewModel();

            var instructor =
                _InstructorService.GetById(id);

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

            return _InstructorService.GetAll();
        }

        // [HttpPut]
        // public void Update(int id, string name)
        // {
        //     var instructor = new Instructor { ID = id, Name = name };

        //     _InstructorService.SaveInclude(instructor, nameof(Instructor.Name));
        //     _InstructorService.SaveChanges();
        // }

    }
}
