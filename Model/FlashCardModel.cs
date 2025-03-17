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

        public DateTime CreatedDate { get; set; }

        public required string Type { get; set; }
    }

    public class FlashCardType
    {
        public const string TextOnly = "Text";
        public const string TextWithImage = "TextWithImage";
    }
}
