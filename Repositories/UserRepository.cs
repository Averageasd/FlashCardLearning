using FlashCardLearning.Context;
using FlashCardLearning.DTOs;
using FlashCardLearning.Model;

namespace FlashCardLearning.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly FlashCardAppContext _appContext;

        public UserRepository(FlashCardAppContext flashCardAppContext)
        {
            _appContext = flashCardAppContext;
        }
        public Task<UserModel> FindUser(LoginDTO loginDTO)
        {
            throw new NotImplementedException();
        }
    }
}
