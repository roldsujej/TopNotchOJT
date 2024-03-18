using Microsoft.AspNetCore.Mvc;

namespace pcg.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChangeInfo()
        {      
            return View();
        }
        public IActionResult Sites()
        {
            return View();
        }
        public IActionResult AddSite()
        {
            return View();
        }
        public IActionResult AddTask()
        {
            return View();
        }
        public IActionResult TaskDetail()
        {
            return View();
        }
        public IActionResult TaskForward()
        {
            return View();
        }
        public IActionResult Pending()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult MyTask()
        {
            return View();
        }
    }
}         