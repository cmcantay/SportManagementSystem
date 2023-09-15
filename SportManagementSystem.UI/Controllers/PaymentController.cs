using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SportManagementSystem.Data.DataContext;
using SportManagementSystem.Data.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SportManagementSystem.UI.Controllers
{
    public class PaymentController : Controller
    {
        private readonly UdemySportManagementSystemContext _db;

        public PaymentController(UdemySportManagementSystemContext db)
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
        public ActionResult Add(List<Payment> payments)
        {

            foreach (var payment in payments)
            {
                if (payment.Amount != 0)
                {
                    _db.Payment.Add(payment);
                }
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
