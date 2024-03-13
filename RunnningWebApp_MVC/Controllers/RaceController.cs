using Microsoft.AspNetCore.Mvc;

namespace RunnningWebApp_MVC.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
