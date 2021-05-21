using highchart_line.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace highchart_line.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            AppsDBEntities context = new AppsDBEntities();

            var query = context.Consultations.Include("Patients")
                   .GroupBy(p => p.Patients.IdPatients)
                   .Select(g => new { name = g.Key, count = g.Sum(w => w.ConsultationID) }).ToList();
            return Json(query,JsonRequestBehavior.AllowGet);
        }
    }
}