using PDL_Task_MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PDL_Task_MVC5.ViewModels
{
    public class DepartmentRetailerVM
    {
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Retailer> Retailers { get; set; }
    }
}