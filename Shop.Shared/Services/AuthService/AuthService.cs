using Shop.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<ServiceReponse<bool>> ChangePassword(string newPassword)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Auth/ChangePassword", newPassword);
            var content = await result.Content.ReadFromJsonAsync<ServiceReponse<bool>>();
            return content;
        }

        public async Task<ServiceReponse<string>> Login(UserLoginDto userLogin)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Auth/Login", userLogin);
            var content = await result.Content.ReadFromJsonAsync<ServiceReponse<string>>();
            return content;
        }

        public async Task<ServiceReponse<int>> Register(UserRegisterDto userRegister)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Auth/Register", userRegister);
            var content = await result.Content.ReadFromJsonAsync<ServiceReponse<int>>();
            return content;
        }
    }
}
