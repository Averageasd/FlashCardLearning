using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Utility
{
    public class FlashCardsFilterUtility
    {
        public static IQueryable<FlashCardModel> Filter(IQueryable<FlashCardModel> query, FlashCardQueryParams flashCardQueryParams)
        {
            if (flashCardQueryParams.FromDate != null && flashCardQueryParams.ToDate != null)
            {
                query = query.Where(x => x.CreatedDate >= flashCardQueryParams.FromDate && x.CreatedDate <= flashCardQueryParams.ToDate);
            }
            else if (flashCardQueryParams.FromDate != null)
            {
                query = query.Where(x => x.CreatedDate >= flashCardQueryParams.FromDate);
            }
            else if (flashCardQueryParams.ToDate != null)
            {
                query = query.Where(x => x.CreatedDate <= flashCardQueryParams.ToDate);
            }

            if (flashCardQueryParams.FilterType != null)
            {
                query = query.Where(x => x.Type == flashCardQueryParams.FilterType);
            }
            return query;
        }
    }
}
