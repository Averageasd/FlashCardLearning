using FlashCardLearning.Context;
using FlashCardLearning.DTOs;
using FlashCardLearning.Mappers;
using FlashCardLearning.Model;
using Microsoft.EntityFrameworkCore;


namespace FlashCardLearning.Repositories
{
    public class FlashCardRepository : IFlashCardRepository
    {

        private readonly FlashCardAppContext _appContext;

        public FlashCardRepository(FlashCardAppContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<FlashCardModel> AddCard(AddNewCardDTO addNewCardDTO)
        {
            var cardModelFromCardDto = FlashCardMapper.FromAddDtoRequestToModel(addNewCardDTO);
            using (var transaction = _appContext.Database.BeginTransaction())
            {
                var newCard = await _appContext.FlashCards.AddAsync(cardModelFromCardDto);
                try
                {
                    await _appContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return newCard.Entity;
                }
                catch(Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }


        public async Task<IEnumerable<FlashCardModel>> GetCards(FlashCardQueryParams flashCardQueryParams)
        {
            try
            {
                IQueryable<FlashCardModel> query = _appContext.FlashCards;
                query = FlashCardsFilterUtility.Filter(query, flashCardQueryParams);
                query = FlashCardsSortUtility.Sort(query, flashCardQueryParams);
                IEnumerable<FlashCardModel> flashCards = await query.AsNoTracking().Take(flashCardQueryParams.VisibleItems).ToAsyncEnumerable(). ToListAsync();
                return flashCards;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public Task<FlashCardModel> UpdateCard(UpdateCardDTO addNewCardDTO)
        {
            throw new NotImplementedException();
        }
    }
}
