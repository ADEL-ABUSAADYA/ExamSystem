using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Instrucotrs;
using ExaminationSystem.ViewModels.Students;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : ControllerBase
    {
        IStudentService _StudentService;

        public StudentController(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }
        #region Student Actions
        [HttpPost]
        public ResponseViewModel<int> Create(StudentCreateViewModel viewModel)
        {
            int StudentID = _StudentService.Add(viewModel);
            
            return new ResponseViewModel<int>(){Data = StudentID, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<StudentViewModel> GetByName(string name)
        {
            var Student = _StudentService.GetByName(name);
            
            return new ResponseViewModel<StudentViewModel>(){Data = Student, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<StudentViewModel> GetByID(int id)
        {
            var Student = _StudentService.GetById(id);

            return new ResponseViewModel<StudentViewModel>(){Data = Student, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpGet]
        public ResponseViewModel<IEnumerable<StudentViewModel>> GetAll()
        {
            var StudentsList = _StudentService.GetAll().ProjectTo<StudentViewModel>();
            return new ResponseViewModel<IEnumerable<StudentViewModel>>(){Data = StudentsList, Message = "Success", ErrorCode = 0, IsSuccess = true};
        }

        [HttpPut]
        public ResponseViewModel<bool> Update(StudentEditViewModel viewModel)
        {
            var isUpdateStudent = _StudentService.UpdateStudent(viewModel);
            return new ResponseViewModel<bool>(){Data = isUpdateStudent, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        }

        [HttpDelete]
        public ResponseViewModel<bool> Delete(int id)
        {
            _StudentService.Delete(id);
            return new ResponseViewModel<bool>(){Message = "Deleted", ErrorCode = 0, IsSuccess = true};
        }
        #endregion
        // IStudentService _StudentService;
        //
        // public StudentController(IStudentService StudentService)
        // {
        //     _StudentService = StudentService;
        // }
        // #region Student Actions
        // [HttpPost]
        // public ResponseViewModel<StudentViewModel> Create(StudentCreateViewModel viewModel)
        // {
        //     int StudentID = _StudentService.Add(viewModel);
        //
        //     var result = _StudentService.GetById(StudentID);
        //     return new ResponseViewModel<StudentViewModel>(){Data = result, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpGet]
        // public ResponseViewModel<StudentViewModel> GetByName(string name)
        // {
        //     var Student = _StudentService.GetByName(name);
        //     
        //     return new ResponseViewModel<StudentViewModel>(){Data = Student, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpGet]
        // public ResponseViewModel<StudentViewModel> GetByID(int id)
        // {
        //     var Student = _StudentService.GetById(id);
        //
        //     return new ResponseViewModel<StudentViewModel>(){Data = Student, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpGet]
        // public ResponseViewModel<IEnumerable<StudentViewModel>> GetAll()
        // {
        //     var Students= _StudentService.GetAll();
        //     return new ResponseViewModel<IEnumerable<StudentViewModel>>(){Data = Students, Message = "Success", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpPut]
        // public ResponseViewModel<bool> Update(StudentEditViewModel viewModel)
        // {
        //     var updateStudent = _StudentService.UpdateStudent(viewModel);
        //     return new ResponseViewModel<bool>(){Data = updateStudent, Message = "Saved", ErrorCode = 0, IsSuccess = true};
        // }
        //
        // [HttpDelete]
        // public ResponseViewModel<bool> Delete(int id)
        // {
        //     _StudentService.Delete(id);
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
        // public IEnumerable<CourseViewModel> GetCoursesByStudent(int StudentId)
        // {
        //     return _CourseService.GetByStudentId(StudentId);
        // }
        //
        // #endregion
    }
}

// [ApiController]
// [Route("[controller]/[action]")]
// public class StudentController : ControllerBase
// {
//     IStudentService _StudentService;
//     ICourseService _CourseService;  // For course management
//     IExamService _ExamService;      // For exam management
//     IStudentService _StudentService; // For student enrollment and management
//
//     public StudentController(
//         IStudentService StudentService,
//         ICourseService CourseService,
//         IExamService ExamService,
//         IStudentService StudentService)
//     {
//         _StudentService = StudentService;
//         _CourseService = CourseService;
//         _ExamService = ExamService;
//         _StudentService = StudentService;
//     }
//
//     #region Student Actions
//
//     [HttpPost]
//     public ResponseViewModel<InstrucorViewModel> Create(StudentCreateViewModel viewModel)
//     {
//         int StudentID = _StudentService.Add(viewModel);
//         var result = _StudentService.GetById(StudentID);
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
//         var Student = _StudentService.GetById(id);
//         return Student;
//     }
//
//     [HttpGet]
//     public IEnumerable<InstrucorViewModel> GetAll()
//     {
//         return _StudentService.GetAll();
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
//     public IEnumerable<CourseViewModel> GetCoursesByStudent(int StudentId)
//     {
//         return _CourseService.GetByStudentId(StudentId);
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