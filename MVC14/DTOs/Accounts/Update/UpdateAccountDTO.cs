namespace MVC14.DTOs.Accounts.Update
{
    public class UpdateAccountDTO : AccountBaseDTO
    {
        public int Balance { get; set; }
        public ChangePasswordDTO? ChangePassword { get; set; }
        public UpdateUserProfileDTO? Profile { get; set; }
    }
}
