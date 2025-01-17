using System.ComponentModel.DataAnnotations;

namespace IdentityUserRegistration.DTO
{
    public class UserForRegistrationDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage ="O Email é obrigatório")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password é obrigatório")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="A Password inserida não são iguais!")]
        public string? ConfirmPassword { get; set; }
    }
}
