
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SportManagementSystem.UI.Controllers
{
    public class RoleManagementController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<IdentityUser> _usermanager;
        public RoleManagementController(UserManager<IdentityUser> usermanager, RoleManager<IdentityRole> roleManager)
        {
            _usermanager = usermanager; 
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var values = _usermanager.Users.ToList();
            return View(values);
        }
        public IActionResult UserRoleList()
        {
            var values= _usermanager.Users.ToList();
            return View(values);
        }

    }
}
