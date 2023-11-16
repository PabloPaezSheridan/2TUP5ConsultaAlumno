using _2TUP5ConsultaAlumnoAPI.Data.Entities;

namespace _2TUP5ConsultaAlumnoAPI.Services.Interfaces
{
    public interface IResponseService
    {
        public Response GetResponse(int id);
        public List<Response> GetAllResponsebyQuestion(int QuestionId);
    }
}
