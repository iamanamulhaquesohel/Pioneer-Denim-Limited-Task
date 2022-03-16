using CrystalDecisions.CrystalReports.Engine;
using PDL_Task_MVC5.Repositories;
using PDL_Task_MVC5.Repositories.Implementaion;
using PDL_Task_MVC5.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDL_Task_MVC5.Controllers
{
    public class DepartmentsController : Controller
    {
        readonly IDepartmentRepository repository;
        public DepartmentsController()
        {
            this.repository = new DepartmentRepository();
        }
        public ActionResult Index(int? selected)
        {
            int deptId = selected.HasValue ? selected.Value : 1;
            var data = new DepartmentRetailerVM
            {
                Departments = this.repository.GetAll(),
                Retailers = this.repository.GetRetailers(deptId)
            };
            return View(data);
        }
        public ActionResult IndexV2()
        {

            return View(this.repository.GetRetailerVM());
        }
        public ActionResult ExportToPdf()
        {
            var data = this.repository.GetRetailerVM();
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Reports"), "DepartmentRetailerReport.rpt"));
            rd.SetDataSource(data);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();


            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", "Retailers.pdf");
        }
        public ActionResult ExportToExcel()
        {
            var data = this.repository.GetRetailerVM();
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Reports"), "DepartmentRetailerReport.rpt"));
            rd.SetDataSource(data);


            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.Excel);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/ms-excel", "Retailer.xls");
        }
    }
}
