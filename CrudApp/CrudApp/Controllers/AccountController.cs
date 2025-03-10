using Microsoft.AspNetCore.Mvc;

namespace CrudApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@example.com" && password == "password")
            {
                // Simulate successful login and redirect
                TempData["Success"] = "Login successful!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Invalid email or password. Please try again.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string name, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ViewBag.Error = "Passwords do not match!";
                return View();
            }

            // Simulate user registration success
            TempData["Success"] = "Registration successful! Please login.";
            return RedirectToAction("Login");
        }
    }
}