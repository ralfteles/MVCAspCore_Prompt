using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore_Prompt.Models
{
    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext(DbContextOptions<MvcEmployeeContext> options)
            : base(options)
        {
        }
        public DbSet<Employees> Employee { get; set; }
    }
}
