using FlashCardLearning.DTOs;

namespace FlashCardLearning.Services
{
    public interface IUserService
    {
        Task FindUser(LoginDTO user);
    }
}
