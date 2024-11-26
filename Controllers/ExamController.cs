using ExaminationSystem.Services.Exams;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Exams;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExamController : ControllerBase
    {
        IExamService _ExamService;

        public ExamController(IExamService ExamService)
        {
            _ExamService = ExamService;
        }
        #region Exam Actions
        [HttpPost]
        public ResponseViewModel<int> Create(ExamCreateViewModel viewModel)
        {
            int ExamID = _ExamService.Add(viewModel);
            
            return new ResponseViewModel<int>(){Data = ExamID, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<ExamViewModel> GetByName(string name)
        {
            var Exam = _ExamService.GetExamByName(name);
            
            return new ResponseViewModel<ExamViewModel>(){Data = Exam, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<ExamViewModel> GetByID(int id)
        {
            var Exam = _ExamService.GetExamByID(id);

            return new ResponseViewModel<ExamViewModel>(){Data = Exam, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<IEnumerable<ExamViewModel>> GetAll()
        {
            var ExamsList = _ExamService.GetAllExams().ProjectTo<ExamViewModel>();
            
            return new ResponseViewModel<IEnumerable<ExamViewModel>>(){Data = ExamsList, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpPut]
        public ResponseViewModel<bool> Update(ExamEditViewModel viewModel)
        {
            var isUpdateExam = _ExamService.UpdateExam(viewModel);
            return new ResponseViewModel<bool>(){Data = isUpdateExam, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        }

        [HttpDelete]
        public ResponseViewModel<bool> Delete(int id)
        {
            _ExamService.Delete(id);
            return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        }
        #endregion
    }
}

