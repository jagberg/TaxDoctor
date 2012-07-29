using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult Accounting()
        {
            return View();
        }

        //public ActionResult OurServices()
        //{
        //    return View();
        //}

        public ActionResult OurServices(string message)
        {
            ViewBag.Message = message;

            return View();
        }

        public ActionResult Bookkeeping() { return View(); }
        public ActionResult FinancialStatements() { return View(); }
        public ActionResult CashFlow() { return View(); }
        public ActionResult BusinessPlans() { return View(); }
        public ActionResult PayrollPAYE() { return View(); }
        public ActionResult TaxServices() { return View(); }
        public ActionResult BankLoanApplications() { return View(); }
        public ActionResult CreditorsReconciliations() { return View(); }
    }
}
