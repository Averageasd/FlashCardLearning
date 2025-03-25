using System.ComponentModel.DataAnnotations;

namespace FlashCardLearning.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="Username is required")]
        [MinLength(5)]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8)]
        public string? Password { get; set; }
    }
}
