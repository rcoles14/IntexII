using Intex.Models;
using Intex.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Controllers
{
    public class AdminController : Controller
    {
        private ICollisionCrisisRepository _repo { get; set; }
        private UserManager<IdentityUser> userManager;

        private SignInManager<IdentityUser> signInManager;

        public AdminController(ICollisionCrisisRepository temp, UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            _repo = temp;
            userManager = um;
            signInManager = sim;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Index(int pageNum = 1)
        {
            
            int pageSize = 50;
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal
                    .OrderBy(c => c.crash_id)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),


                    PageInfo = new PageInfo
                    {
                        TotalNumCrashes = _repo.CrashNormal.Count(),
                        CrashesPerPage = pageSize,
                        CurrentPage = pageNum
                    }

                };

                return View(x);
         
            
        }
        [Authorize]
        [HttpPost]
        public IActionResult Index(int ID, int pageNum = 1)
        {

            int pageSize = 50;
            var x = new CrashNormalViewModel
            {

                CrashNormal = _repo.CrashNormal.Where(p => p.crash_id == ID),


                PageInfo = new PageInfo
                {
                    TotalNumCrashes = _repo.CrashNormal.Count(),
                    CrashesPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };

            return View(x);


        }
        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.County = _repo.CrashNormal.Select(x => x.county_name).Distinct().OrderBy(x => x).ToList();

                return View();

        }
        [HttpPost]
        public IActionResult Add(CrashNormal c)
        {
            
            _repo.Add(c);
            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.County = _repo.CrashNormal.OrderBy(x => x.county_name).Select(x => x.county_name).Distinct().ToList();
            var crash = _repo.CrashNormal.Single(x => x.crash_id == id);
            return View("Add", crash);
        }
        [HttpPost]
        public IActionResult Edit(CrashNormal cn)
        {
            _repo.Update(cn); 

                return RedirectToAction("Index");

        }
            
        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var crash = _repo.CrashNormal.Single(x => x.crash_id == id);
                return View("Delete", crash);

        }
            
        
        [HttpPost]
        public IActionResult Delete(CrashNormal d)
        {
            _repo.Delete(d);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Login(string returnUrl)

        {
            return View(new LoginModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByNameAsync(loginModel.Username);

                if (user != null)
                {
                    await signInManager.SignOutAsync();

                    if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect(loginModel?.ReturnUrl ?? "/Admin");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid name or password");
            return View(loginModel);

        }

        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();

            return Redirect(returnUrl);
        }
    }
}
