namespace IdentityUserRegistration.DTO
{
    public class RegistrationResponseDTO
    {
        public bool IsSuccess {  get; set; }
        public IEnumerable<string>Errors { get; set; }
    }
}
