using PDL_Task_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PDL_Task_Core.ViewModels;

namespace PDL_Task_Core.Repositories.Implementaion
{
    public class DepartmentRepository : IDepartmentRepository
    {
        readonly PDL_TaskContext db;
        public DepartmentRepository(PDL_TaskContext _db) { this.db = _db; }
        
        public IEnumerable<Departments> GetAll()
        {
            return this.db.Departments;
        }
        public IEnumerable<Retailers> GetRetailers(int selectedItem)
        {
            return this.db
                .Departments
                .Include(x=> x.Retailers)
                .First(x => x.DepartmentId == selectedItem)
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
