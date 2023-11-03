using System.ComponentModel.DataAnnotations;

namespace _2TUP5ConsultaAlumnoAPI.Data.Models
{
    public class ProfessorPostDto
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string UserName { get; set; }



    }
}
