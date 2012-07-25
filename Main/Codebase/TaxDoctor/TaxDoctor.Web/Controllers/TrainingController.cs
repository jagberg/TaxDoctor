using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class TrainingController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accounting()
        {
            return View();
        }

        public ActionResult Excel()
        {
            return View();
        }

        public ActionResult Pastel()
        {
            return View();
        }

        public ActionResult QuickBooks()
        {
            return View();
        }

        public ActionResult Packages(string message)
        {
            ViewBag.Message = message;

            return View();
        }
    }
}
