using Microsoft.AspNetCore.Mvc;

namespace YetGenAkbankJump.MvcClient.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
