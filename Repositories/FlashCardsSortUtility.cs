using FlashCardLearning.DTOs;
using FlashCardLearning.Model;
using System.Linq.Dynamic.Core;

namespace FlashCardLearning.Repositories
{
    public class FlashCardsSortUtility
    {
        public static IQueryable<FlashCardModel> Sort(IQueryable<FlashCardModel> query, FlashCardQueryParams flashCardQueryParams)
        {
            String sortOption = flashCardQueryParams.Sort == "asc" ? "ascending" : "descending";
            query = query.OrderBy($"{flashCardQueryParams.OrderCol} {sortOption}, Id ascending");

            // fetching next n records starting from the last seen one
            if (flashCardQueryParams.LastSeenId != 0)
            {
                if (flashCardQueryParams.OrderCol == "CreatedDate")
                {
                    if (flashCardQueryParams.Sort == "asc")
                    {
                        query = query.Where(x =>
                           x.CreatedDate > flashCardQueryParams.LastSeenDateTime || x.CreatedDate == flashCardQueryParams.LastSeenDateTime && x.Id > flashCardQueryParams.LastSeenId
                        );
                    }
                    else
                    {
                        query = query.Where(x =>
                           x.CreatedDate < flashCardQueryParams.LastSeenDateTime || x.CreatedDate == flashCardQueryParams.LastSeenDateTime && x.Id > flashCardQueryParams.LastSeenId
                        );
                    }

                }
                else if (flashCardQueryParams.OrderCol == "Name")
                {
                    if (flashCardQueryParams.Sort == "asc")
                    {
                        query = query.Where(x =>
                           x.Name.CompareTo(flashCardQueryParams.LastSeenName) > 0 || x.Name.CompareTo(flashCardQueryParams.LastSeenName) == 0 && x.Id > flashCardQueryParams.LastSeenId
                        );
                    }
                    else
                    {
                        query = query.Where(x =>
                          x.Name.CompareTo(flashCardQueryParams.LastSeenName) < 0 || x.Name.CompareTo(flashCardQueryParams.LastSeenName) == 0 && x.Id > flashCardQueryParams.LastSeenId
                       );
                    }
                }
            }
            
            return query;
        }
    }
}
