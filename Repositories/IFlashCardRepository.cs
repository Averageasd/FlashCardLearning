using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Repositories
{
    public interface IFlashCardRepository
    {
        Task<IEnumerable<FlashCardModel>> GetCards(FlashCardQueryParams flashCardQueryParams);

        Task<FlashCardModel> AddCard(AddNewCardDTO addNewCardDTO);
        Task<FlashCardModel> UpdateCard(int id, FlashCardModel flashCard,    UpdateCardDTO addNewCardDTO);

        Task<FlashCardModel> GetSingleCard(int id);

        Task DeleteCard(int id);    
    }
}
