using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreLatest.Models;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreLatest.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<IdentityUser> _userManger;
        public HomeController(UserManager<IdentityUser> userManger)
        {
            _userManger = userManger;
        }
        public IActionResult Index()
        {
            string userId = _userManger.GetUserId(HttpContext.User); 
            string userName = _userManger.GetUserName(HttpContext.User); 

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
