namespace MVC14.DTOs.Accounts.Create
{
    public class RegisterDTO : AccountBaseDTO
    {
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public CreateUserProfileDTO? Profile { get; set; }
    }
}
