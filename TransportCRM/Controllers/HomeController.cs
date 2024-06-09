using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TransportCRM.Data;
using TransportCRM.Models;

namespace TransportCRM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TransportCRMContext _context;

        public HomeController(ILogger<HomeController> logger, TransportCRMContext context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Test = _context.ActivePages.FirstOrDefault();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
