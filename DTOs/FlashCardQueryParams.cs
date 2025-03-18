namespace FlashCardLearning.DTOs
{
    public class FlashCardQueryParams
    {

        // last visible record
        public int LastSeenId { get; set; } = 0;
        public string? LastSeenName { get; set; } = "";
        public string? LastSeenSearchType { get; set; } = "";
        public DateTime? LastSeenDateTime { get; set; } = null;

        // number of visible items
        public int VisibleItems { get; set; } = 20;

        // filters
        public DateTime? FromDate { get; set; } = null;
        public DateTime? ToDate { get; set; } = null;
        public string? FilterType { get; set; } = null;

        public String? OrderCol { get; set; } = "CreatedDate";

        public String? Sort { get; set; } = SortingOrder.DescOrder;
    }

    public class SortingOrder
    {
        public const string AscOrder = "asc";
        public const string DescOrder = "desc";
    }
}