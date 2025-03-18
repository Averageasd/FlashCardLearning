using ExecutionPlanVisualizer;
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
            using var transaction = await _appContext.Database.BeginTransactionAsync();
            var newCard = await _appContext.FlashCards.AddAsync(cardModelFromCardDto);
            try
            {
                await _appContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return newCard.Entity;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task DeleteCard(int id)
        {

            using var transaction = await _appContext.Database.BeginTransactionAsync();
            try
            {
                await _appContext.FlashCards.Where(x => x.Id == id).ExecuteDeleteAsync();
                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<IEnumerable<FlashCardModel>> GetCards(FlashCardQueryParams flashCardQueryParams)
        {
            try
            {
                IQueryable<FlashCardModel> query = _appContext.FlashCards;
                query = FlashCardSearchUtility.Search(query, flashCardQueryParams);
                query = FlashCardsFilterUtility.Filter(query, flashCardQueryParams);
                query = FlashCardsSortUtility.Sort(query, flashCardQueryParams);
                QueryPlanVisualizer.DumpPlan(query);
                IEnumerable<FlashCardModel> flashCards = await query.AsNoTracking().Take(flashCardQueryParams.VisibleItems).ToAsyncEnumerable(). ToListAsync();
                return flashCards;
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
                var findSingleCardQuery = _appContext.FlashCards.Where(x => x.Id == id);
                return await findSingleCardQuery.FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task<FlashCardModel> UpdateCard(int id,FlashCardModel flashCard, UpdateCardDTO addNewCardDTO)
        {
            using var transaction = _appContext.Database.BeginTransaction();
            try
            {
                flashCard.Description = addNewCardDTO.Description;
                flashCard.Name = addNewCardDTO.Name;
                flashCard.Type = addNewCardDTO.Type;
                await _appContext.SaveChangesAsync();
                await transaction.CommitAsync();
                return flashCard;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }

        }
    }
}
