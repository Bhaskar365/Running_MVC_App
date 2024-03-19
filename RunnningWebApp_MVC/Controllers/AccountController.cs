using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RunnningWebApp_MVC.Data;
using RunnningWebApp_MVC.Models;
using RunnningWebApp_MVC.ViewModels;

namespace RunnningWebApp_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ApplicationDbContext _context;
        public AccountController(UserManager<AppUser> userManager, 
                                SignInManager<AppUser> signInManager,
                                ApplicationDbContext context) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Login()
        {
            var response = new LoginViewModel();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel) 
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            var user = await _userManager.FindByEmailAsync(loginViewModel.EmailAddress);

            if(user != null) 
            {
                // user is found, check password
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                if(passwordCheck) 
                {
                    // password correct
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                    if (result.Succeeded) 
                    {
                        return RedirectToAction("Index", "Race");
                    }
                }
                // password is incorrect
                TempData["Error"] = "Wrong credentials. Please try again.";
                return View(loginViewModel);
            }
            // user not found
            TempData["Error"] = "User not found";
            return View(loginViewModel);
        }

        public IActionResult Register()
        {
            var response = new RegisterViewModel();
            return View(response);
        }


    }
}
