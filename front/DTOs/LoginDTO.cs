using System.ComponentModel.DataAnnotations;

namespace front.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Senha é obrigatória.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "A senha deve ter no mínimo 8 digítos")]
        public string Senha { get; set; } = string.Empty;
        public bool LembrarDeMim { get; set; }
    }
}
