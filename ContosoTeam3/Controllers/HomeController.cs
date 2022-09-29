using ContosoTeam3.Data;
using ContosoTeam3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ContosoTeam3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContosoTeam3Context _context;

        public HomeController(ILogger<HomeController> logger, ContosoTeam3Context context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Session.ToListAsync());
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

        public IActionResult BookSeat()
        {

        }
    }
}