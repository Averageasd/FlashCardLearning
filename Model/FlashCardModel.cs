using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlashCardLearning.Model
{
    public class FlashCardModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Card name is required")]
        [MinLength(5), MaxLength(150)]
        public required string Name { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Answer is required")]
        [MinLength(5), MaxLength(200)]
        public required string Answer { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public required string Type { get; set; }
    }

    public class FlashCardType
    {
        public const string Basic = "Basic";
        public const string Advanced = "Advanced";
    }
}
