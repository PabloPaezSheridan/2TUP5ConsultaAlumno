using _2TUP5ConsultaAlumnoAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _2TUP5ConsultaAlumnoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorService _professorService;

        public ProfessorController(IProfessorService professorService)
        {
            _professorService = professorService;
        }


    }
}
