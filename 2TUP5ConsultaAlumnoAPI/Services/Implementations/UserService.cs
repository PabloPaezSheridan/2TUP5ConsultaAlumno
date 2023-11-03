using _2TUP5ConsultaAlumnoAPI.Data;
using _2TUP5ConsultaAlumnoAPI.Data.Entities;
using _2TUP5ConsultaAlumnoAPI.Services.Interfaces;
using _2TUP5ConsultaAlumnoAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace _2TUP5ConsultaAlumnoAPI.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly ConsultaContext _consultaContext;

        public UserService(ConsultaContext consultaContext)
        {
            _consultaContext = consultaContext;
        }


        public User? GetUserByEmail(string email)
        {
            return _consultaContext.Users.SingleOrDefault(u => u.Email == email);
        }
        public BaseResponse ValidarUsuario(string email, string password)
        {
            BaseResponse response = new BaseResponse();
            User? userForLogin = _consultaContext.Users.SingleOrDefault(u => u.Email == email);
            if (userForLogin != null)
            {
                if (userForLogin.Password == password)
                {
                    response.Result = true;
                    response.Message = "loging Succesfull";
                }
                else
                {
                    response.Result = false;
                    response.Message = "wrong password";
                }
            }
            else
            {
                response.Result = false;
                response.Message = "wrong email";
            }
            return response;
        }


        public int CreateUser(User user)
        {
            _consultaContext.Add(user);
            _consultaContext.SaveChanges();
            return user.Id;
        }

        public void UpdateUser(User user)
        {
            _consultaContext.Update(user);
            _consultaContext.SaveChanges();

        }

        public void DeleteUser(int userId )
        {
            User userToDelete= _consultaContext.Users.FirstOrDefault(u => u.Id == userId);
            userToDelete.State = false;
            _consultaContext.Update(userToDelete);
            _consultaContext.SaveChanges();

        }

    }
}
