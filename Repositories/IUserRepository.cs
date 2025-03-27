using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Repositories
{
    public interface IUserRepository
    {
        Task<UserModel> FindUser(LoginDTO loginDTO);
    }
}
