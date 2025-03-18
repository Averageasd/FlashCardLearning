using FlashCardLearning.Context;
using FlashCardLearning.DTOs;
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

        public async Task<IEnumerable<FlashCardModel>> GetCards(FlashCardQueryParams flashCardQueryParams)
        {
            try
            {
                IQueryable<FlashCardModel> query = _appContext.FlashCards;
                query = FlashCardsFilterUtility.Filter(query, flashCardQueryParams);
                query = FlashCardsSortUtility.Sort(query, flashCardQueryParams);
                IEnumerable<FlashCardModel> flashCards = await query.Take(flashCardQueryParams.VisibleItems).ToAsyncEnumerable().ToListAsync();
                return flashCards;
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}
