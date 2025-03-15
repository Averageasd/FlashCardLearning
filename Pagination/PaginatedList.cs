namespace FlashCardLearning.Pagination
{
    public class ScrollList<T>
    {
        public int PageSize { get; set; }
        public List<T> Data { get; set; }   
    }
}
