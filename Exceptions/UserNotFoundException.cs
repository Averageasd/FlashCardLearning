namespace FlashCardLearning.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(Guid id) : base($"Cannot find user with id ${id}") 
        { }
    }
}
