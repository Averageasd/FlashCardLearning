using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Mappers
{
    public class FlashCardMapper
    {
        public static FlashCardModel FromAddDtoResponseToModel(AddNewCardDTO addNewCardDTO)
        {
            return new FlashCardModel
            {
                Name = addNewCardDTO.Name,
                Type = addNewCardDTO.Type,
                Description = addNewCardDTO.Description,
                CreatedDate = DateTime.Now,
            };
        }
    }
}
