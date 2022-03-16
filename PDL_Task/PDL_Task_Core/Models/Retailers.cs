using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PDL_Task_Core.Models
{
    public partial class Retailers
    {
        public int RetailerId { get; set; }
        public string RetailerCode { get; set; }
        public string RetailerName { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
    }
}
