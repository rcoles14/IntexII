using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class EFCollisionCrisisRepository : ICollisionCrisisRepository
    {

        private crashnormalDbContext _context { get; set; }
        public EFCollisionCrisisRepository (crashnormalDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<crashnormal> crashnormal => _context.crashnormal;

        public void Add(crashnormal c)
        {
            if (c.crash_id == 0)
            {
                _context.crashnormal.Add(c);
            }
            _context.SaveChanges();
        }
        public void Update(crashnormal cn)
        {
            _context.crashnormal.Update(cn);
            _context.SaveChanges();
        }

        public void Delete(crashnormal d)
        {
            _context.crashnormal.Remove(d);
            _context.SaveChanges();
        }

    }
}
