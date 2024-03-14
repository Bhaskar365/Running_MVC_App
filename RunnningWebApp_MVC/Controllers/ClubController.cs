using Microsoft.AspNetCore.Mvc;
using RunnningWebApp_MVC.Data;

namespace RunnningWebApp_MVC.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var clubs = _context.Clubs.ToList();
            return View(clubs);
        }
    }
}
