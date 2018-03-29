using IdentityRolePRoject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IdentityRolePRoject.Controllers
{
    public class RoleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Role
        public ActionResult Index()
        {
            return View(db.Roles.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create([Bind(Include = "Id, Name")]RoleViewModel roleViewModel)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            if (ModelState.IsValid)
            {
                var role = new IdentityRole(roleViewModel.Name);
                var roleresult = await roleManager.CreateAsync(role);
            }
            return View(roleViewModel);
        }
    }
}