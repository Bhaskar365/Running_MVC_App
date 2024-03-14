using Microsoft.AspNetCore.Mvc;
using RunnningWebApp_MVC.Data;

namespace RunnningWebApp_MVC.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var races = _context.Races.ToList();
            return View(races);
        }
    }
}
