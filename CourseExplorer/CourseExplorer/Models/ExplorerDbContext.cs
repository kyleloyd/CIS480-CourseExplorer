using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CourseExplorer.Models
{
    public class ExplorerDbContext : DbContext
    {
        public ExplorerDbContext() : base("CourseExplorer") 
        { 
        
        }

        public DbSet<Course> Courses { get; set; }
    }
}