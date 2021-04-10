using System.ComponentModel.DataAnnotations;

namespace CookieAuthApp.ViewModels
{
    public class RegisterModel : LoginModel
    {
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Incorrect password")]
        public string ConfirmPassword { get; set; }
    }
}
