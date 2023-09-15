using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SportManagementSystem.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           // return Redirect("/Identity/Account/Login");
           return View();   

        }
    }
}