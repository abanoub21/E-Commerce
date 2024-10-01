using E.Commerce.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserLoginDto obj)
        {
            return View();
        }
    }
}
