using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Mappers
{
    public class FlashCardMapper
    {
        public static FlashCardModel FromAddDtoRequestToModel(AddNewCardDTO addNewCardDTO)
        {
            return new FlashCardModel
            {
                Name = addNewCardDTO.Name,
                Type = addNewCardDTO.Type,
                Description = addNewCardDTO.Description,
                CreatedDate = DateTime.Now,
            };
        }

        public static FlashCardModel FromUpdateDTORequestToModel(UpdateCardDTO updateCardDTO)
        {
            return new FlashCardModel
            {
                Name = updateCardDTO.Name,
                Type = updateCardDTO.Type,
                Description = updateCardDTO.Description,
                CreatedDate = DateTime.Now,
            };
        }
    }
}
