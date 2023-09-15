using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using SportManagementSystem.Data.DataContext;
using SportManagementSystem.Data.DbModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportManagementSystem.Controllers
{
    public class RoleAdminController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<Employee> _userManager;
        public RoleAdminController(UserManager<Employee> usermanager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = usermanager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        public IActionResult UserRoleList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(string id) 
        {
            var user = _userManager.Users.FirstOrDefault(x =>x.Id == id);
            var roles=_roleManager.Roles.ToList();
            TempData["UserId"] = user.Id;
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach (var role in roles) { 
            RoleAssignViewModel m= new RoleAssignViewModel();
                m.RoleId = role.Id;
                    m.Name = role.Name;
                m.Exists = userRoles.Contains(role.Name);
                model.Add(m);
            }

                return View(model);
        
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userId = TempData["UserId"];
            var user=_userManager.Users.FirstOrDefault(y => y.Id == userId);
            foreach (var item in model)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);

                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserRoleList");
        }
        [HttpPost]
        public async Task<IActionResult> AddAtlethes(List<Athletes> model)
        {
            var userId = TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(y => y.Id == userId);
            foreach (var item in model)
            {
         
            }
            return RedirectToAction("UserRoleList");
        }
    }
}
