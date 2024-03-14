using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunnningWebApp_MVC.Data;
using RunnningWebApp_MVC.Models;

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
        public IActionResult Detail(int id) 
        {
            Race race = _context.Races.Include(a => a.Address).FirstOrDefault(r => r.Id == id);
            return View(race);
        }
    }
}
