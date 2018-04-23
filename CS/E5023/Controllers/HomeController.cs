using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using E5023.Models;
using E5023.Reports;

namespace E5023.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }        

        public ActionResult DocumentViewerPartial() {
            var model = Category.GetCategories();
            return PartialView("_DocumentViewerPartial", model);
        }

        public ActionResult DocumentViewerPartialExport() {
            CategoriesReport report = new CategoriesReport();
            report.DataSource = Category.GetCategories();
            return ReportViewerExtension.ExportTo(report);
        }
    }
}