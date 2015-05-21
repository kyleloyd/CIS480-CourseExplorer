using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseExplorer.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designator { get; set; }
        public int Credits { get; set; }

    }
}