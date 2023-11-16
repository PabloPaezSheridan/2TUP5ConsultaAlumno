using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using _2TUP5ConsultaAlumnoAPI.Services.Interfaces;
using _2TUP5ConsultaAlumnoAPI.Services.Implementations;
using _2TUP5ConsultaAlumnoAPI.Data.Entities;

namespace _2TUP5ConsultaAlumnoAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ResponseController : ControllerBase
    {
        public readonly IResponseService _responseService;

        public ResponseController (IResponseService responseService)
        {
            _responseService = responseService;
        }


        [HttpGet("{id}")]
        public IActionResult GetResponse([FromRoute] int id) 
        {
            return Ok(_responseService.GetResponse(id));
        }
        [HttpGet("question/{questionId}")]

        public IActionResult GetAllResponsebyQuestion([FromRoute] int questionId)

        { 
            return Ok(_responseService.GetAllResponsebyQuestion(questionId));
        }

    }
}
