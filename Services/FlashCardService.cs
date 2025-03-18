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

        public Task AddCard(AddNewCardDTO addNewCardDTO)
        {
            throw new NotImplementedException();
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
    }
}
