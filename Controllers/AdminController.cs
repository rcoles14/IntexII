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
        public IActionResult Index(string filter, bool B, int pageNum = 1)
        {
            ViewBag.Selected = filter;


            int pageSize = 50;
            if (filter == "work_zone_related")
            {

                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.work_zone_related == B)
                    .OrderBy(c => c.crash_id)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),


                    PageInfo = new PageInfo
                    {
                        TotalNumCrashes = _repo.CrashNormal.Where(p => p.work_zone_related == B).Count(),
                        CrashesPerPage = pageSize,
                        CurrentPage = pageNum
                    }

                };

                return View(x);
            }
            else if (filter == "pedestrian_involved")
            {

                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.pedestrian_involved == B)
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
            else if (filter == "bicyclist_involved")
            {


                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.bicyclist_involved == B)
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
            else if (filter == "motorcycle_involved")
            {

                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.motorcycle_involved == B)
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
            else if (filter == "improper_restraint")
            {


                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.improper_restraint == B)
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
            else if (filter == "unrestrained")
            {


                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.unrestrained == B)
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
            else if (filter == "dui")
            {


                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.dui == B)
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
            else if (filter == "intersection_related")
            {


                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.intersection_related == B)
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
            else if (filter == "wild_animal_related")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.wild_animal_related == B)
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
            else if (filter == "domestic_animal_related")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.domestic_animal_related == B)
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
            else if (filter == "overturn_rollover")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.overturn_rollover == B)
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
            else if (filter == "commercial_motor_veh_involved")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.commercial_motor_veh_involved == B)
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
            else if (filter == "teenage_driver_involved")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.teenage_driver_involved == B)
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
            else if (filter == "older_driver_involved")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.older_driver_involved == B)
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
            else if (filter == "night_dark_condition")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.night_dark_condition == B)
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
            else if (filter == "single_vehicle")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.single_vehicle == B)
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
            else if (filter == "distracted_driving")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.distracted_driving == B)
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
            else if (filter == "drowsy_driving")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.drowsy_driving == B)
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
            else if (filter == "roadway_departure")
            {
                var x = new CrashNormalViewModel
                {

                    CrashNormal = _repo.CrashNormal.Where(p => p.roadway_departure == B)
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

            else
            {
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
