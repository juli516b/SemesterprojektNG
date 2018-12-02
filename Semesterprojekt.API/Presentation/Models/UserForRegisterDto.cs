using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Semesterprojekt.API.Presentation.Models
{
    public class UserDtoForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Adgangskoden er for kort. Den skal mindst være 8 bogstaver")]
        public string Password { get; set; }
    }
}