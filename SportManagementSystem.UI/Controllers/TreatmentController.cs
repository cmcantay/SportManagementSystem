using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SportManagementSystem.Data.DataContext;
using SportManagementSystem.Data.DbModels;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SportManagementSystem.UI.Controllers
{
    public class TreatmentController : Controller
    {
        private readonly UdemySportManagementSystemContext _db;

        public TreatmentController(UdemySportManagementSystemContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Athletes> list = _db.Athletes.ToList();
            return View(list);
        }

        // Ekle butonuna basıldığında çalışacak kod

        [HttpPost]
        public ActionResult Add(List<Treatment> treatments)
        {

            foreach (var treatment in treatments)
            {
                if (treatment.Disability!=null)
                {
                    _db.Treatment.Add(treatment);
                    break;
                }
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult LastTreatment(int? userId)
        {
            if (userId == null)
            {
                // Handle the case where userId is not provided
                // For example, redirect to an error page or return a specific view
                return RedirectToAction("Index", "Home"); // Redirect to the home page
            }

            List<Treatment> list = _db.Treatment.Where(x => x.UserId == userId).ToList();
            return View(list);
        }

    }
}
