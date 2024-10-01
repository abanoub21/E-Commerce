using E.Commerce.Application.Contract;
using E.Commerce.Application.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRoleAppServices services;

        public AccountController(IUserRoleAppServices services)
        {
            this.services = services;
        }

        [HttpPost]
        public async Task<IdentityUser> Registration(RegistrationDto obj)
        {
            return await services.Registration(obj);
        }

        [HttpGet]
        public async Task<List<IdentityUser>> GetAllUsers()
        {
            return await services.GetAllUsers();    
        }

        [HttpGet]
        public async Task<List<IdentityUser>> GetAllUsersByRoleName(string RoleName)
        {
            return await services.GetAllUsersByRoleName(RoleName);
        }

        [HttpPost]
        public async Task<CustomToken> Login(UserLoginDto Obj)
        {
            return await services.Login(Obj);   
        }
    }
}
