using Microsoft.AspNetCore.Mvc;
using PDL_Task_Core.Repositories;
using PDL_Task_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDL_Task_Core.Controllers
{
    public class DepartmentsController : Controller
    {
        readonly IDepartmentRepository repository;
        public DepartmentsController(IDepartmentRepository _repository) { this.repository = _repository; }

        public IActionResult Index(int? selected)
        {
            int deptId = selected.HasValue ? selected.Value : 1;
            var data = new DepartmentRetailerVM
            {
                Departments = this.repository.GetAll(),
                Retailers = this.repository.GetRetailers(deptId)
            };
            return View(data);
        }

        public IActionResult IndexV2()
        {

            return View(this.repository.GetRetailerVM());
        }
    }
}
