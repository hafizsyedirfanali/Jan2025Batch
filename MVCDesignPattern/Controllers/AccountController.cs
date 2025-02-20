using Microsoft.AspNetCore.Mvc;

namespace MVCDesignPattern.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UpdateEmail()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UpdatePassword()
        {
            return View();
        }
    }
}
