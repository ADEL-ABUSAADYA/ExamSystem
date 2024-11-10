using ExaminationSystem.Data;
using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.ViewModels.Exams;
using ExaminationSystem.ViewModels.Instrucotrs;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExamController : ControllerBase
    {
        IExamService _examService;
       
        public ExamController()
        {
            _examService = new ExamService();
        }

        [HttpPost]
        public string Create(ExamCreateViewModel viewModel)
        {
            _examService.Add(viewModel);

            return "Done";
        }
    }
}
