using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models.ViewModels
{
    public class CrashNormalViewModel
    {
        public IQueryable<crashnormal> crashnormal { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
