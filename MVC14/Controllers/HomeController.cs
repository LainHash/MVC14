using Microsoft.AspNetCore.Mvc;
using MVC14.Helpers.Constants.Sessions;
using MVC14.Models;
using System.Diagnostics;

namespace MVC14.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var sessionId = HttpContext.Session.GetString(SessionConstants.sessionId);
            if(string.IsNullOrEmpty(sessionId)) {
                HttpContext.Session.SetString(SessionConstants.sessionId, HttpContext.Session.Id);
            }
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
