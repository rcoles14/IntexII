using Intex.Models;
using Intex.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private ICollisionCrisisRepository _repo { get; set; }



        public HomeController(ICollisionCrisisRepository temp)
        {
            _repo = temp;

        }
        public IActionResult Reports(string filter, bool B, int pageNum = 1)
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
            } else if (filter == "pedestrian_involved")
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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
