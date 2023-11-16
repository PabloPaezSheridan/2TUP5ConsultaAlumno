using _2TUP5ConsultaAlumnoAPI.Data.Entities;
using _2TUP5ConsultaAlumnoAPI.Data.Models;

namespace _2TUP5ConsultaAlumnoAPI.Services.Interfaces
{
    public interface IUserService
    {

        public BaseResponse ValidarUsuario(string username, string password);
        public User? GetUserByEmail(string username);
        public User? GetUserById(int id);
        public int CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int userId);

    }
}
