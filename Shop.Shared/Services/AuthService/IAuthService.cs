using Shop.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceReponse<string>> Login(UserLoginDto userLogin);

        Task<ServiceReponse<int>> Register(UserRegisterDto userRegister);

        Task<ServiceReponse<bool>> ChangePassword(string newPassword);
    }
}
