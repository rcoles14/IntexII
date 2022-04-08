using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Models
{
    public class crashnormalDbContext : DbContext
    {
        public crashnormalDbContext(DbContextOptions<crashnormalDbContext> options) : base(options)
        {

        }
        public DbSet<crashnormal> crashnormal { get; set; }
    }
}
