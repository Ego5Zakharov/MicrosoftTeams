using Microsoft.AspNetCore.Mvc;

namespace MicrosoftTeams.Controllers
{
    public class Conference : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Thanks()
        {
            return View();
        }
    }
}
