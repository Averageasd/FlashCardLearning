using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Repositories
{
    public class FlashCardSearchUtility
    {
        public static IQueryable<FlashCardModel> Search(IQueryable<FlashCardModel> query, FlashCardQueryParams flashCardQueryParams)
        {
            if (string.IsNullOrEmpty(flashCardQueryParams.SearchField) || string.IsNullOrWhiteSpace(flashCardQueryParams.SearchField))
            {
                return query;
            }

            return query.Where(
                x => x.Name.ToLower().StartsWith(flashCardQueryParams.SearchField.ToLower()) 
                || x.Name.ToLower().EndsWith(flashCardQueryParams.SearchField.ToLower()) 
                || x.Name.ToLower().Contains(flashCardQueryParams.SearchField.ToLower()));

        }
    }
}
