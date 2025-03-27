namespace FlashCardLearning.Exceptions
{
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException(string username, string password) : base($"Invalid credentials")
        { }
    }
}
