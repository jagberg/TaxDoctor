using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class HomeController : BaseController
    {
        [PageTitle("Affordable accounting, bookkeeping, payroll and tax returns | Accountant in Johannesburg area")]
        [MetaDescription("We offer an affordable service for all your tax concerns and including accounting, bookkeeping, training and personal tax returns.")]
        [MetaKeywords("tax, bookkeeping, bookkeeper, payroll, paye, irp5, irp6, it12, it14, emp201, emp501, vat201, cashflow, financial statements, company formations, annual returns, cipc, cipro, sars, sars easyfile, tax sumbission, workmens compensation, audits, quickbooks, pastel payroll, excel, sdl, uif, ck, tax clearance certificates, accounting officer")]
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Tax Doctor";

            return View();
        }

        [PageTitle("About us - Affordable accounting, bookkeeping, payroll and tax returns in Johannesburg area")]
        [MetaDescription("We offer an affordable service for all your tax concerns including accounting, bookkeeping, training and personal tax returns.")]
        [MetaKeywords("about tax doctor, accountant, tax services, bookkeeping, bookkeeper, payroll, training, bookkeeping trainning, accounting training, company registration, company formation, sars, sars easyfile, cipro")]
        public ActionResult About()
        {
            return View();
        }
    }
}
