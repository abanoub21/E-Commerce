using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using E.Commerce.Domain.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E.Commerce.Application.Services
{
    public class AccountAppServices : IUserRoleAppServices
    {
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager;

        public AccountAppServices(Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager) 
        {
            this.userManager = userManager;
        }
        public async Task<IdentityUser> Registration(RegistrationDto obj)
        {
          IdentityUser user = new IdentityUser();
            user.UserName = obj.UserName;
            user.PhoneNumber = obj.MobileNo;
            user.Email = obj.Email;
            var data = await userManager.CreateAsync(user, obj.Password);

            if (data.Succeeded) 
            {
                var result = await userManager.AddToRoleAsync(user, "User");
            }
            return user;
        }
        public async Task<List<IdentityUser>> GetAllUsers()
        {
            var data = userManager.Users;
            return await data.ToListAsync();
        }

        public async Task<List<IdentityUser>> GetAllUsersByRoleName(string RoleName)
        {
            var data = await userManager.GetUsersInRoleAsync(RoleName);
            return data.ToList();
        }
        public async Task<CustomToken> Login(UserLoginDto Obj)
        {
            var user = await userManager.FindByNameAsync(Obj.UserName); 
            if (user != null  && await userManager.CheckPasswordAsync(user , Obj.Password)) 
            {
                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var userRoles = await userManager.GetRolesAsync(user);
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, Constantts.RoleName.Role));

                }

                var token = GetToken(authClaims);

                CustomToken tok = new CustomToken();
                tok.Token = new JwtSecurityTokenHandler().WriteToken(token);
                tok.Expiration = token.ValidTo;
                return tok;

            }
            else
            {
                return new CustomToken();
            }
        }
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("JWTAuthenticationHIGHsecuredPasswordVVVp1OH7Xzyr"));

            var token = new JwtSecurityToken(
                issuer: "http://localhost:5100",
                audience: "http://localhost:5100",
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    } 
}