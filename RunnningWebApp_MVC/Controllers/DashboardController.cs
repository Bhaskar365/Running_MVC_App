using Microsoft.AspNetCore.Mvc;

namespace RunnningWebApp_MVC.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
