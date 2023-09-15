using Microsoft.AspNetCore.Mvc;

namespace SportManagementSystem.UI.Controllers
{
    public class ActivityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
