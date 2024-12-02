using ExaminationSystem.Services.Courses;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Courses;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CourseController : ControllerBase
    {
        ICourseService _CourseService;

        public CourseController(ICourseService CourseService)
        {
            _CourseService = CourseService;
        }
        #region Course Actions
        [HttpPost]
        public ResponseViewModel<int> Create(CourseCreateViewModel viewModel)
        {
            int CourseID = _CourseService.Create(viewModel);
            
            return new ResponseViewModel<int>(){Data = CourseID, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<CourseViewModel> GetByName(string name)
        {
            var Course = _CourseService.GetByName(name);
            
            return new ResponseViewModel<CourseViewModel>(){Data = Course, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<CourseViewModel> GetByID(int id)
        {
            var Course = _CourseService.GetById(id);

            return new ResponseViewModel<CourseViewModel>(){Data = Course, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<IEnumerable<CourseViewModel>> GetAll()
        {
            var CoursesList = _CourseService.GetAll().ProjectTo<CourseViewModel>();
            
            return new ResponseViewModel<IEnumerable<CourseViewModel>>(){Data = CoursesList, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpPut]
        public ResponseViewModel<bool> Update(CourseEditViewModel viewModel)
        {
            var isUpdateCourse = _CourseService.UpdateCourse(viewModel);
            return new ResponseViewModel<bool>(){Data = isUpdateCourse, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        }

        [HttpDelete]
        public ResponseViewModel<bool> Delete(int id)
        {
            _CourseService.Delete(id);
            return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        }
        #endregion
    }
}

