using _2TUP5ConsultaAlumnoAPI.Data;
using _2TUP5ConsultaAlumnoAPI.Data.Entities;
using _2TUP5ConsultaAlumnoAPI.Services.Interfaces;

namespace _2TUP5ConsultaAlumnoAPI.Services.Implementations
{
    public class ProfessorService : IProfessorService
    {
        private readonly ConsultaContext _context;

        public ProfessorService(ConsultaContext context)
        {
            _context = context;
        }

        //public List<Professor> GetAll()
        //{
        //    return _context.Professors.ToList();
        //}

        public List<User> GetProfessors()
        {
            return _context.Users.Where(p => p.UserType == "Professor").ToList();
        }

    }
}
