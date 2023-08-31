using System.ComponentModel.DataAnnotations;

namespace Chapter.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail necessario")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha necessaria")]
        public string Senha { get; set; }
    }
}
