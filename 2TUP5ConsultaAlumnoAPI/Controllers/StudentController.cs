using _2TUP5ConsultaAlumnoAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _2TUP5ConsultaAlumnoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

    }
}
