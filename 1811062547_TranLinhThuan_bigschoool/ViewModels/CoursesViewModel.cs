using _1811062547_TranLinhThuan_bigschoool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811062547_TranLinhThuan_bigschoool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

    }
}