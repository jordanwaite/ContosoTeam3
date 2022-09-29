using ContosoTeam3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContosoTeam3.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CreateCookie()
        {
            string key = "Contoso_Cookie";
            string value = "Stored Cookie Value";
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Append(key, value, options);
            return View("Index");
    }
    public IActionResult ReadCookie()
    {
            string key = "Contoso_Cookie";
            var cookieValue = Request.Cookies[key];
            return View("Index");
        }
    public IActionResult RemoveCookie()
    {
            string key = "Contoso_Cookie";
            string value = string.Empty;
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(-1)
            };
            Response.Cookies.Append(key, value, options);
            return View("Index");
        }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}