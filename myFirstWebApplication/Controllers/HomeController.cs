using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using myFirstWebApplication.Models;
using myFirstWebApplication.Services;

namespace myFirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        //public IPaisRepositorio Repositorio { get; }

        //public HomeController(IPaisRepositorio repositorio)
        //{
        //    Repositorio = repositorio;
        //}

        //public IActionResult Index()
        //{
        //    List<Pais> paises = Repositorio.ObtenerTodos();
        //    return View(paises);
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public HomeController(UserManager<ApplicationUser> pUserManager, RoleManager<IdentityRole> pRoleManager)
        {
            this.userManager = pUserManager;
            this.roleManager = pRoleManager;
        }

        //public async Task<IActionResult> IndexAsync()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        var claims = User.Claims.ToList();
        //        var user = await userManager.GetUserAsync(HttpContext.User);
        //        await userManager.AddClaimAsync(user, new Claim("CategoriaEmpleado", "4"));
        //    }

        //    return View();
        //}

        //public async Task<IActionResult> About()
        //{
        //if (User.Identity.IsAuthenticated)
        //{
        //    await roleManager.CreateAsync(new IdentityRole("Admin"));
        //    var user = await userManager.GetUserAsync(HttpContext.User);
        //    await userManager.AddToRoleAsync(user, "Admin");
        //}

        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var claims = User.Claims.ToList();
                var user = await userManager.GetUserAsync(HttpContext.User);
                await userManager.AddClaimAsync(user, new Claim("CategoriaEmpleado", "4"));
            }

            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        //[Authorize(Roles = "Admin")]
        [Authorize(Policy = "PolicyCategoriaEmpleado")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
