using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseExplorer.Models
{
    public class Objective
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Description { get; set; }
    }
}