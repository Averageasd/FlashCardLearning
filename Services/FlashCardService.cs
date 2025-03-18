using FlashCardLearning.DTOs;
using FlashCardLearning.Model;
using FlashCardLearning.Repositories;

namespace FlashCardLearning.Services
{
    public class FlashCardService : IFlashCardService
    {
        private readonly IFlashCardRepository _flashCardRepository;
        public FlashCardService(IFlashCardRepository flashCardRepository)
        {
            _flashCardRepository = flashCardRepository;
        }

        public async Task<FlashCardModel> AddCard(AddNewCardDTO addNewCardDTO)
        {
            try
            {
                return await _flashCardRepository.AddCard(addNewCardDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteCard(int id)
        {
            try
            {
                var existingCard = await _flashCardRepository.GetSingleCard(id);
                if (existingCard == null)
                {
                    throw new Exception();
                }
                await _flashCardRepository.DeleteCard(id);
            }
            catch (Exception)
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
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<FlashCardModel> GetSingleCard(int id)
        {
            try
            {
                var returnedCard = await _flashCardRepository.GetSingleCard(id);
                if (returnedCard == null)
                {
                    throw new Exception();
                }
                return returnedCard;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<FlashCardModel> UpdateCard(int id, UpdateCardDTO updateCardDTO)
        {
            try
            {
                var existingCard = await _flashCardRepository.GetSingleCard(id);
                if (existingCard == null)
                {
                    throw new Exception();
                }
                return await _flashCardRepository.UpdateCard(id, existingCard, updateCardDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
