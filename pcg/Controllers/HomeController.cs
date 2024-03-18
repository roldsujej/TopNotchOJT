using Microsoft.AspNetCore.Mvc;
using pcg.Models;

namespace pcg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {           
            return View();
        }
        public ActionResult Register()
        {
            return View();        
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
       
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsersModel a)
        {
            return RedirectToAction("Index", "Admin");
        }
    }
}
