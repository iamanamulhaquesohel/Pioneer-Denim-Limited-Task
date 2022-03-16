using PDL_Task_MVC5.Models;
using PDL_Task_MVC5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PDL_Task_MVC5.Repositories.Implementaion
{
    public class DepartmentRepository : IDepartmentRepository
    {
        readonly PDL_TaskContext db = new PDL_TaskContext();
        public DepartmentRepository() { }
        public IEnumerable<Department> GetAll()
        {
            return this.db.Departments;
        }
        public IEnumerable<Retailer> GetRetailers(int selected)
        {
            return this.db.
                Departments
                .Include(x => x.Retailers)
                .First(x => x.DepartmentId == selected)
                .Retailers
                .ToList();
        }

        public IEnumerable<RetailerVM> GetRetailerVM()
        {
            List<RetailerVM> data = new List<RetailerVM>();
            this.db
                .Retailers
                .Include(x => x.Department)
                .ToList()
                .ForEach(x =>
                {
                    data.Add(new RetailerVM
                    {
                        DepartmentName = x.Department.DepartmentName,
                        DepartmentCode = x.Department.DepartmentCode,
                        RetailerName = x.RetailerName,
                        RetailerCode = x.RetailerCode
                    });
                });

            return data;
        }

       
    }
}