using System.ComponentModel.DataAnnotations;

namespace FlashCardLearning.DTOs
{
    public class UpdateCardDTO
    {
        [Required(ErrorMessage = "Card name is required")]
        [MinLength(5), MaxLength(150)]
        public required string Name { get; set; }

        public string? Description { get; set; }

        public required string Type { get; set; }
    }
}
