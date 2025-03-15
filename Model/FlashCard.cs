using System.ComponentModel.DataAnnotations;

namespace FlashCardLearning.Model
{
    public class FlashCard
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string type { get; set; }
    }

    public class FlashCardType
    {
        public const string TextOnly = "Text";
        public const string TextWithImage = "TextWithImage";
    }
}
