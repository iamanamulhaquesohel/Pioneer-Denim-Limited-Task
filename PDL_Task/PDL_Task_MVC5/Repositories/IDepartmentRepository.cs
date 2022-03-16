using PDL_Task_MVC5.Models;
using PDL_Task_MVC5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDL_Task_MVC5.Repositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        IEnumerable<Retailer> GetRetailers(int selectedItem);
        IEnumerable<RetailerVM> GetRetailerVM();
    }
}
