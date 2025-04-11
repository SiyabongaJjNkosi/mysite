using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public IActionResult Index()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        public IActionResult Authenticate(string username, string password)
        {
            // Example: Replace with actual authentication logic
            if (username == "admin" && password == "password")
            {
                return RedirectToAction("Dashboard", "Home");
            }

            ViewBag.ErrorMessage = "Invalid username or password";
            return View("Index");
        }
    }
}