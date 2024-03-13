using Microsoft.AspNetCore.Mvc;

namespace RunnningWebApp_MVC.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
