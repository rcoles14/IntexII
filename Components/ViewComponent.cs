using Microsoft.AspNetCore.Mvc;
using Intex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Intex.Components
{
    public class FilterViewComponent : ViewComponent
    {
        private ICollisionCrisisRepository _repo { get; set; }

        public FilterViewComponent (ICollisionCrisisRepository temp)
        {
            _repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            
            var filter = _repo.CrashNormal;
            return View(filter);

        }
    }
}
