using System.ComponentModel.DataAnnotations;

namespace FlashCardLearning.Model
{
    public class UserModel
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }    
        public string? Password { get; set; }   

    }
}
