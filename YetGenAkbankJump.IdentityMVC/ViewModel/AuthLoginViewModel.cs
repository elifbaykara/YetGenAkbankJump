using System.ComponentModel.DataAnnotations;

namespace YetGenAkbankJump.IdentityMVC.ViewModel
{
    public class AuthLoginViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
