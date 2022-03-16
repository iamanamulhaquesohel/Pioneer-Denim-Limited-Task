using PDL_Task_Core.Models;
using PDL_Task_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDL_Task_Core.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Departments> GetAll();
        IEnumerable<Retailers> GetRetailers(int selectedItem);
        IEnumerable<RetailerVM> GetRetailerVM();
    }
}
