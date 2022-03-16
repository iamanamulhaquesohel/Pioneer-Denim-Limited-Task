using PDL_Task_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDL_Task_Core.ViewModels
{
    public class DepartmentRetailerVM
    {
        public IEnumerable<Departments> Departments { get; set; }
        public IEnumerable<Retailers> Retailers { get; set; }
    }
}
