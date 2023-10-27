using System.ComponentModel.DataAnnotations;

namespace _2TUP5ConsultaAlumnoAPI.Data.Models
{
    public class CredentialsDto
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
