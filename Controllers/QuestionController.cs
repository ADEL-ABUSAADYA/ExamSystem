using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Questions;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class QuestionController : ControllerBase
    {
        IQuestionService _QuestionService;

        public QuestionController(IQuestionService QuestionService)
        {
            _QuestionService = QuestionService;
        }
        #region Question Actions
        [HttpPost]
        public ResponseViewModel<int> Create(QuestionCreateViewModel viewModel)
        {
            int QuestionID = _QuestionService.Add(viewModel);
            
            return new ResponseViewModel<int>(){Data = QuestionID, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<QuestionViewModel> GetByID(int id)
        {
            var Question = _QuestionService.GetQuestionByID(id);

            return new ResponseViewModel<QuestionViewModel>(){Data = Question, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }
        

        [HttpPut]
        public ResponseViewModel<bool> Update(QuestionEditViewModel viewModel)
        {
            var isUpdateQuestion = _QuestionService.UpdateQuestion(viewModel);
            return new ResponseViewModel<bool>(){Data = isUpdateQuestion, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        }

        [HttpDelete]
        public ResponseViewModel<bool> Delete(int id)
        {
            _QuestionService.DeleteQuestion(id);
            return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        }
        #endregion
    }
}

