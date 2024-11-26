using ExaminationSystem.Data;
using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.Services.GenaricService;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Courses;
using ExaminationSystem.ViewModels.Instrucotrs;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GroupController : ControllerBase
    {
        IService<Group,BaseViewModel> _GroupService;

        public GroupController(IService<Group,BaseViewModel> GroupService)
        {
            _GroupService = GroupService;
        }
        #region Group Actions
        [HttpPost]
        public ResponseViewModel<GroupViewModel> Create(GroupCreateViewModel viewModel)
        {
            int GroupID = _GroupService.Add(viewModel);

            var result = _GroupService.GetById(GroupID);
            return new ResponseViewModel<GroupViewModel>(){Data = (GroupViewModel)result, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<GroupViewModel> GetByName(string name)
        {
            var Group = _GroupService.GetByName(name);
            
            return new ResponseViewModel<GroupViewModel>(){Data = (GroupViewModel)Group, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<GroupViewModel> GetByID(int id)
        {
            var Group = _GroupService.GetById(id);

            return new ResponseViewModel<GroupViewModel>(){Data = (GroupViewModel)Group, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<IEnumerable<GroupViewModel>> GetAll()
        {
            var Groups= _GroupService.GetAll();
            var result = Groups.ProjectTo<GroupViewModel>();
            return new ResponseViewModel<IEnumerable<GroupViewModel>>(){Data = result, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpPut]
        public ResponseViewModel<bool> Update(GroupEditViewModel viewModel)
        {
            var updateGroup = _GroupService.Update(viewModel);
            return new ResponseViewModel<bool>(){Data = updateGroup, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        }

        [HttpDelete]
        public ResponseViewModel<bool> Delete(int id)
        {
            _GroupService.Delete(id);
            return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        }
        #endregion
        // IGroupService _GroupService;
        //
        // public GroupController(IGroupService GroupService)
        // {
        //     _GroupService = GroupService;
        // }
        // #region Group Actions
        // [HttpPost]
        // public ResponseViewModel<GroupViewModel> Create(GroupCreateViewModel viewModel)
        // {
        //     int GroupID = _GroupService.Add(viewModel);
        //
        //     var result = _GroupService.GetById(GroupID);
        //     return new ResponseViewModel<GroupViewModel>(){Data = result, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpGet]
        // public ResponseViewModel<GroupViewModel> GetByName(string name)
        // {
        //     var Group = _GroupService.GetByName(name);
        //     
        //     return new ResponseViewModel<GroupViewModel>(){Data = Group, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpGet]
        // public ResponseViewModel<GroupViewModel> GetByID(int id)
        // {
        //     var Group = _GroupService.GetById(id);
        //
        //     return new ResponseViewModel<GroupViewModel>(){Data = Group, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpGet]
        // public ResponseViewModel<IEnumerable<GroupViewModel>> GetAll()
        // {
        //     var Groups= _GroupService.GetAll();
        //     return new ResponseViewModel<IEnumerable<GroupViewModel>>(){Data = Groups, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpPut]
        // public ResponseViewModel<bool> Update(GroupEditViewModel viewModel)
        // {
        //     var updateGroup = _GroupService.UpdateGroup(viewModel);
        //     return new ResponseViewModel<bool>(){Data = updateGroup, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpDelete]
        // public ResponseViewModel<bool> Delete(int id)
        // {
        //     _GroupService.Delete(id);
        //     return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        // }
        // #endregion
        
        // #region Course Management
        
        // [HttpPost]
        // public ResponseViewModel<CourseViewModel> CreateCourse(CourseCreateViewModel viewModel)
        // {
        //     int courseId = _CourseService.Add(viewModel);
        //     var course = _CourseService.GetById(courseId);
        //     return new ResponseViewModel<CourseViewModel>()
        //     {
        //      Data = course,
        //      Message = "Course created successfully.",
        //      ErrorCode = 0,
        //      IsSuccess = true
        //     };
        // }
        //
        // [HttpPut]
        // public IActionResult UpdateCourse(int id, CourseUpdateViewModel viewModel)
        // { 
        //     _CourseService.Update(id, viewModel);
        //     return Ok(new { Message = "Course updated successfully." });
        // }
        //
        // [HttpDelete]
        // public IActionResult DeleteCourse(int id)
        // {
        //     _CourseService.Delete(id);
        //     return Ok(new { Message = "Course deleted successfully." });
        // }
        //
        // [HttpGet]
        // public IEnumerable<CourseViewModel> GetCoursesByGroup(int GroupId)
        // {
        //     return _CourseService.GetByGroupId(GroupId);
        // }
        //
        // #endregion
    }
}

// [ApiController]
// [Route("[controller]/[action]")]
// public class GroupController : ControllerBase
// {
//     IGroupService _GroupService;
//     ICourseService _CourseService;  // For course management
//     IExamService _ExamService;      // For exam management
//     IStudentService _StudentService; // For student enrollment and management
//
//     public GroupController(
//         IGroupService GroupService,
//         ICourseService CourseService,
//         IExamService ExamService,
//         IStudentService StudentService)
//     {
//         _GroupService = GroupService;
//         _CourseService = CourseService;
//         _ExamService = ExamService;
//         _StudentService = StudentService;
//     }
//
//     #region Group Actions
//
//     [HttpPost]
//     public ResponseViewModel<InstrucorViewModel> Create(GroupCreateViewModel viewModel)
//     {
//         int GroupID = _GroupService.Add(viewModel);
//         var result = _GroupService.GetById(GroupID);
//         return new ResponseViewModel<InstrucorViewModel>()
//         {
//             Data = result,
//             Message = "Success",
//             ErrorCode = 0,
//             IsSuccess = true
//         };
//     }
//
//     [HttpGet]
//     public InstrucorViewModel GetByID(int id)
//     {
//         var Group = _GroupService.GetById(id);
//         return Group;
//     }
//
//     [HttpGet]
//     public IEnumerable<InstrucorViewModel> GetAll()
//     {
//         return _GroupService.GetAll();
//     }
//
//     #endregion
//
//     #region Course Management
//
//     [HttpPost]
//     public ResponseViewModel<CourseViewModel> CreateCourse(CourseCreateViewModel viewModel)
//     {
//         int courseId = _CourseService.Add(viewModel);
//         var course = _CourseService.GetById(courseId);
//         return new ResponseViewModel<CourseViewModel>()
//         {
//             Data = course,
//             Message = "Course created successfully.",
//             ErrorCode = 0,
//             IsSuccess = true
//         };
//     }
//
//     [HttpPut]
//     public IActionResult UpdateCourse(int id, CourseUpdateViewModel viewModel)
//     {
//         _CourseService.Update(id, viewModel);
//         return Ok(new { Message = "Course updated successfully." });
//     }
//
//     [HttpDelete]
//     public IActionResult DeleteCourse(int id)
//     {
//         _CourseService.Delete(id);
//         return Ok(new { Message = "Course deleted successfully." });
//     }
//
//     [HttpGet]
//     public IEnumerable<CourseViewModel> GetCoursesByGroup(int GroupId)
//     {
//         return _CourseService.GetByGroupId(GroupId);
//     }
//
//     #endregion
//
//     #region Exam Management
//
//     [HttpPost]
//     public ResponseViewModel<ExamViewModel> CreateExam(ExamCreateViewModel viewModel)
//     {
//         int examId = _ExamService.Add(viewModel);
//         var exam = _ExamService.GetById(examId);
//         return new ResponseViewModel<ExamViewModel>()
//         {
//             Data = exam,
//             Message = "Exam created successfully.",
//             ErrorCode = 0,
//             IsSuccess = true
//         };
//     }
//
//     [HttpPut]
//     public IActionResult AssignQuestionsToExam(int examId, AssignQuestionsViewModel viewModel)
//     {
//         _ExamService.AssignQuestions(examId, viewModel);
//         return Ok(new { Message = "Questions assigned to exam successfully." });
//     }
//
//     [HttpGet]
//     public ExamViewModel GetExam(int id)
//     {
//         return _ExamService.GetById(id);
//     }
//
//     [HttpDelete]
//     public IActionResult DeleteExam(int id)
//     {
//         _ExamService.Delete(id);
//         return Ok(new { Message = "Exam deleted successfully." });
//     }
//
//     #endregion
//
//     #region Student Enrollment and Exam Assignment
//
//     [HttpPost]
//     public IActionResult EnrollStudentInCourse(EnrollStudentViewModel viewModel)
//     {
//         _StudentService.EnrollInCourse(viewModel);
//         return Ok(new { Message = "Student enrolled in course successfully." });
//     }
//
//     [HttpPost]
//     public IActionResult AssignExamToStudent(AssignExamViewModel viewModel)
//     {
//         _ExamService.AssignExamToStudent(viewModel);
//         return Ok(new { Message = "Exam assigned to student successfully." });
//     }
//
//     #endregion
// }