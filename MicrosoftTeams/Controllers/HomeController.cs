using Microsoft.AspNetCore.Mvc;
using MicrosoftTeams.Models;
using System.Diagnostics;

namespace MicrosoftTeams.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Service _service;
        public HomeController(ILogger<HomeController> logger,Service service)
        {
            _service = service;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult SendEmailDefault()
        {
            _service.SendEmailDefault();
            return RedirectToAction("Index");
        }
        public IActionResult SendEmailCustom()
        {
            _service.SendEmailDefault();
            return RedirectToAction("Index");
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