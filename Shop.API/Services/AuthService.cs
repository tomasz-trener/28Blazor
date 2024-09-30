using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Shop.API.Models;
using Shop.Shared;
using Shop.Shared.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Shop.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;





        public AuthService(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public Task<ServiceReponse<string>> ChangePasswordAsync(int userId, string newPasswrod)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceReponse<string>> LoginAsync(string email, string password)
        {
            var response = new ServiceReponse<string>();
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower().Equals(email.ToLower()));
            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found";
            }
            else if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                response.Success = false;
                response.Message = "Wrong password";
            }
            else
            {
                response.Data = CreateToken(user);
                response.Message = "Login success";
                response.Success = true;
            }
            return response;
        }

        private string? CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>()
             {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Role, user.Role),
                new Claim("DateCreated", user.DateCreated.ToString())
             };

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
            );

            var tokenHandler = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenHandler;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        public async Task<ServiceReponse<int>> RegisterAsync(User user, string password)
        {
            if (await UserExists(user.Email))
            {
                return new ServiceReponse<int>
                {
                    Success = false,
                    Message = "User already exists"
                };
            }

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return new ServiceReponse<int>
            {
                Data = user.Id,
                Success = true,
                Message = "User created successfully"
            };

        }
        public async Task<bool> UserExists(string email)
        {
            if (await _context.Users.AnyAsync(x => x.Email.ToLower().Equals(email.ToLower())))
            {
                return true;
            }
            return false;
        }


        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}