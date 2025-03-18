using FlashCardLearning.DTOs;
using FlashCardLearning.Model;
using FlashCardLearning.Repositories;

namespace FlashCardLearning.Services
{
    public class FlashCardService : IFlashCardService
    {
        private readonly IFlashCardRepository _flashCardRepository;
        public FlashCardService(IFlashCardRepository flashCardRepository) {
            _flashCardRepository = flashCardRepository; 
        }

        public async Task<FlashCardModel> AddCard(AddNewCardDTO addNewCardDTO)
        {
            try
            {
                return await _flashCardRepository.AddCard(addNewCardDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<FlashCardModel>> GetCards(FlashCardQueryParams flashCardQueryParams)
        {
            try
            {
                return await _flashCardRepository.GetCards(flashCardQueryParams);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public Task<FlashCardModel> GetSingleCard(AddNewCardDTO cardDTO)
        {
            throw new NotImplementedException();
        }
    }
}
