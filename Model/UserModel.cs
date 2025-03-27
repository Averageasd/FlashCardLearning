using System.ComponentModel.DataAnnotations;

namespace FlashCardLearning.Model
{
    public class UserModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [MinLength(5)]
        public required string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8)]
        public required string Password { get; set; }
        public ICollection<FlashCardModel>? FlashCardModels { get; set; }

    }
}
