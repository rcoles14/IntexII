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
                        TotalNumCrashes = _repo.CrashNormal.Count(),
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
