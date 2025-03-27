using System.ComponentModel.DataAnnotations;

namespace FlashCardLearning.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="Username is required")]
        [MinLength(5)]
        public required string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8)]  
        public required string Password { get; set; }
    }
}
