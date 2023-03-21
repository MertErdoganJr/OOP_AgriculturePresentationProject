using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentationProject.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        public string password { get; set; }
    }
}
