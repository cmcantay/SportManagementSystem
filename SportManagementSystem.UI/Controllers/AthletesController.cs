using Microsoft.AspNetCore.Mvc;
using SportManagementSystem.Data.DataContext;
using SportManagementSystem.Data.DbModels;
using System.Collections.Generic;
using System.Linq;

namespace SportManagementSystem.UI.Controllers
{
    public class AthletesController : Controller
    {
        private readonly UdemySportManagementSystemContext _db;

        public AthletesController(UdemySportManagementSystemContext db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            List<Athletes> list = _db.Athletes.ToList();
            return View(list);
        }
    }
}
