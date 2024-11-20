using ExaminationSystem.Data;
using ExaminationSystem.Data.Repository;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Instrucotrs;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class InstructorController : ControllerBase
    {
        IInstructorService _InstructorService;

        public InstructorController(IInstructorService InstructorService)
        {
            _InstructorService = InstructorService;
        }
        #region Instructor Actions
        [HttpPost]
        public ResponseViewModel<InstructorViewModel> Create(InstructorCreateViewModel viewModel)
        {
            int instructorID = _InstructorService.Add(viewModel);

            var result = _InstructorService.GetById(instructorID);
            return new ResponseViewModel<InstructorViewModel>(){Data = result, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<InstructorViewModel> GetByName(string name)
        {
            var instructor = _InstructorService.GetByName(name);
            
            return new ResponseViewModel<InstructorViewModel>(){Data = instructor, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<InstructorViewModel> GetByID(int id)
        {
            var instructor = _InstructorService.GetById(id);

            return new ResponseViewModel<InstructorViewModel>(){Data = instructor, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<IEnumerable<InstructorViewModel>> GetAll()
        {
            var instructors= _InstructorService.GetAll();
            return new ResponseViewModel<IEnumerable<InstructorViewModel>>(){Data = instructors, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpPut]
        public ResponseViewModel<InstructorViewModel> Update(InstructorEditViewModel viewModel)
        {
            var updateInstructor = _InstructorService.UpdateInstructor(viewModel);
            return new ResponseViewModel<InstructorViewModel>(){Data = updateInstructor, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpDelete]
        public ResponseViewModel<bool> Delete(int id)
        {
            _InstructorService.Delete(id);
            return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        }
        #endregion
        
        // #region Course Management
        //
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
        // public IEnumerable<CourseViewModel> GetCoursesByInstructor(int instructorId)
        // {
        //     return _CourseService.GetByInstructorId(instructorId);
        // }
        //
        // #endregion
    }
}

// [ApiController]
// [Route("[controller]/[action]")]
// public class InstructorController : ControllerBase
// {
//     IInstructorService _InstructorService;
//     ICourseService _CourseService;  // For course management
//     IExamService _ExamService;      // For exam management
//     IStudentService _StudentService; // For student enrollment and management
//
//     public InstructorController(
//         IInstructorService InstructorService,
//         ICourseService CourseService,
//         IExamService ExamService,
//         IStudentService StudentService)
//     {
//         _InstructorService = InstructorService;
//         _CourseService = CourseService;
//         _ExamService = ExamService;
//         _StudentService = StudentService;
//     }
//
//     #region Instructor Actions
//
//     [HttpPost]
//     public ResponseViewModel<InstrucorViewModel> Create(InstructorCreateViewModel viewModel)
//     {
//         int instructorID = _InstructorService.Add(viewModel);
//         var result = _InstructorService.GetById(instructorID);
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
//         var instructor = _InstructorService.GetById(id);
//         return instructor;
//     }
//
//     [HttpGet]
//     public IEnumerable<InstrucorViewModel> GetAll()
//     {
//         return _InstructorService.GetAll();
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
//     public IEnumerable<CourseViewModel> GetCoursesByInstructor(int instructorId)
//     {
//         return _CourseService.GetByInstructorId(instructorId);
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