using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentConsumerMicroservice.Services;

namespace StudentConsumerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        // GET api/student/details?email={email}&password={password}
        //[HttpGet("details")]
        //public async Task<IActionResult> GetStudentDetails(string email, string password)
        //{
        //    var studentDetails = await _studentService.GetStudentDetailsAsync(email, password);

        //    if (studentDetails == null)
        //    {
        //        return NotFound("Student not found or invalid credentials.");
        //    }

        //    return Ok(studentDetails);
        //}
    }
}
