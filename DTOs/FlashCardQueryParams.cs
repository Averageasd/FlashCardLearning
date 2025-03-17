namespace FlashCardLearning.DTOs
{
    public class FlashCardQueryParams
    {

        // last visible record
        public int LastSeenId { get; set; } = 0;
        public string? LastSeenName { get; set; } = "";
        public string? LastSeenSearchType { get; set; } = "";
        public DateTime? LastSeenDateTime { get; set; } = null;


        public string? OrderBy { get; set; }
    }
}