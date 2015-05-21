using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseExplorer.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("CourseExplorer")
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}