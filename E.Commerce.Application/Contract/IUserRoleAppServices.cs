using E.Commerce.Application.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Commerce.Application.Contract
{
    public interface IUserRoleAppServices
    {
        Task<List<IdentityUser>> GetAllUsers();
        Task<List<IdentityUser>> GetAllUsersByRoleName(string RoleName);
        Task<IdentityUser> Registration(RegistrationDto obj);
        Task<CustomToken> Login(UserLoginDto Obj);
    }
}
