using Shop.Shared;
using Shop.Shared.Auth;

namespace Shop.API.Services
{
    public interface IAuthService
    {
        Task<ServiceReponse<string>> LoginAsync(string email, string password);

        Task<ServiceReponse<int>> RegisterAsync(User user, string password);

        Task<ServiceReponse<string>> ChangePasswordAsync(int userId, string newPasswrod);
        Task<bool> UserExists(string email);
    }
}
