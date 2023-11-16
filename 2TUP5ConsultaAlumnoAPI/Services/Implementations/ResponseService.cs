using _2TUP5ConsultaAlumnoAPI.Data;
using _2TUP5ConsultaAlumnoAPI.Data.Entities;
using _2TUP5ConsultaAlumnoAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _2TUP5ConsultaAlumnoAPI.Services.Implementations
{
    public class ResponseService : IResponseService
    {

        private readonly ConsultaContext _context;

        public ResponseService(ConsultaContext context)
        {
            _context = context;
        }


        public Response? GetResponse(int id)
 
        {
            return _context.Responses
                .Include(r => r.Creator)
                .Include(r => r.Question)
                .SingleOrDefault(x => x.Id == id);
        }

        public List<Response> GetAllResponsebyQuestion(int questionId)
        { 
                return  _context.Responses
                .Include(r => r.Creator)
                .Where(r => r.QuestionId == questionId)
                .ToList();

        }

    }
}
