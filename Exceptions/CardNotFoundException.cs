namespace FlashCardLearning.Exceptions
{
    public class CardNotFoundException : Exception
    {
        public CardNotFoundException(int cardId) : base($"card with {cardId} cannot be found")
        {
        }
    }
}
