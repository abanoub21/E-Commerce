using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.Web.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var userid = HttpContext.Session.GetString("userid");
            return View();
        }
    }
}
