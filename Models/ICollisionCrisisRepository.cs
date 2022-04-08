using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public interface ICollisionCrisisRepository
    {
        IQueryable<crashnormal> crashnormal { get;  }


        void Add(crashnormal c);
        void Update(crashnormal bn);
        void Delete(crashnormal d);
    }
}
