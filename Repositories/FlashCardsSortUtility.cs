using FlashCardLearning.DTOs;
using FlashCardLearning.Model;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace FlashCardLearning.Repositories
{
    public class FlashCardsSortUtility
    {
        public static IQueryable<FlashCardModel> Sort(IQueryable<FlashCardModel> query, FlashCardQueryParams flashCardQueryParams)
        {
            if (string.IsNullOrWhiteSpace(flashCardQueryParams.OrderBy))
            {
                query = query.OrderByDescending(x => x.Id);
                if (flashCardQueryParams.LastSeenId != 0)
                {
                    query = query.Where(x => x.Id > flashCardQueryParams.LastSeenId);
                }
            }

            else
            {
                bool isIdColumnIncluded = false;
                StringBuilder strBuilder = new StringBuilder();
                String[] sortPairs = flashCardQueryParams.OrderBy.Trim().Split(',');
                var propertyInfos = typeof(FlashCardModel).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (string sortPair in sortPairs)
                {
                    String[] sortPairArr = sortPair.Trim().Split(' ');
                    String col = sortPairArr[0];
                    String order = sortPairArr[1];
                    var objectProperty = propertyInfos.FirstOrDefault(property =>
                    property.Name.Equals(col, StringComparison.InvariantCultureIgnoreCase));
                    if (objectProperty is null)
                    {
                        continue;
                    }

                    String propertyName = objectProperty.Name.ToString();
                    var direction = sortPairArr[1] == "desc" ? "descending" : "ascending";
                    strBuilder.Append($"{propertyName} {direction}, ");
                    if (propertyName == "Name")
                    {
                        if (flashCardQueryParams.LastSeenName != "")
                        {
                            if (direction == "descending")
                            {
                                query = query.Where(x => x.Name.CompareTo(flashCardQueryParams.LastSeenName) < 0);
                            }
                            else
                            {
                                query = query.Where(x => x.Name.CompareTo(flashCardQueryParams.LastSeenName) > 0);
                            }
                        }
                    }

                    else if (propertyName == "Id")
                    {
                        isIdColumnIncluded = true;
                        if (flashCardQueryParams.LastSeenId != 0)
                        {
                            if (direction == "descending")
                            {
                                query = query.Where(x => x.Id < flashCardQueryParams.LastSeenId);
                            }
                            else
                            {
                                query = query.Where(x => x.Id > flashCardQueryParams.LastSeenId);
                            }
                        }
                    }

                    else if (propertyName == "Type")
                    {
                        if (flashCardQueryParams.LastSeenSearchType != "")
                        {
                            if (direction == "descending")
                            {
                                query = query.Where(x => x.Type.CompareTo(flashCardQueryParams.LastSeenSearchType) < 0);
                            }
                            else
                            {
                                query = query.Where(x => x.Type.CompareTo(flashCardQueryParams.LastSeenSearchType) > 0);
                            }
                        }
                    }

                    else if (propertyName == "CreatedDate")
                    {
                        if (flashCardQueryParams.LastSeenSearchType != "")
                        {
                            if (direction == "descending")
                            {
                                query = query.Where(x => x.CreatedDate < (flashCardQueryParams.LastSeenDateTime));
                            }
                            else
                            {
                                query = query.Where(x => x.CreatedDate > flashCardQueryParams.LastSeenDateTime);
                            }
                        }
                    }
                }

                var orderQuery = strBuilder.ToString().TrimEnd(',', ' ');
                query = query.OrderBy(orderQuery);
                if (!isIdColumnIncluded)
                {
                    if (flashCardQueryParams.LastSeenId != 0)
                    {
                        query = query.Where(x => x.Id  < flashCardQueryParams.LastSeenId);  
                    }
                }
            }
                

            return query;
        }
    }
}
