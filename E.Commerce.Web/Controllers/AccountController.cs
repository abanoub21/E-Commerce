using Microsoft.AspNetCore.Mvc;
using E.Commerce.Web.BackendServices;
using Microsoft.AspNetCore.Http;

namespace E.Commerce.Web.Controllers
{
    public class AccountController : Controller
    {
        Client client = new Client("http://localhost:5100/");
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto obj) 
        {
            if(ModelState.IsValid)
            {
                var userdata = await client.LoginAsync(obj);
                if(userdata.Id != null) 
                {
                    HttpContext.Session.SetString("userid", userdata.Id);
                    HttpContext.Session.SetString("username", userdata.UserName);
                    return RedirectToAction("Index", "Home");
                }

            }
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserRoleDto obj)
        {
            var data = client.AddUserWithRoleAsync(obj).Result;
            
                return RedirectToAction("Login");
            
        }
    }
}
