using Microsoft.AspNetCore.Mvc;

namespace E.Commerce.Web.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Notificate()
        {
            return View();
        }
    }
}
