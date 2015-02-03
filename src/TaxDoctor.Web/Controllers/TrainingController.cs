using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class TrainingController : BaseController
    {
        [PageTitle("Affordable training for accounting, bookkeeping, tax in Johannesburg area | Excel, Quickbooks and Pastel Payroll training")]
        [MetaDescription("Save on costs by training staff on accounting, bookkeeping and tax. We also provide training on Quickbooks, Pastel Payroll and Excel and tailor this towards your business. We help you ensure you are up to date with the latest tax regulations.")]
        [MetaKeywords("quickbooks, pastel payroll, excel, training, tax, bookkeeping, bookkeeper, payroll, paye, cashflow, financial statements, annual returns, cipc, cipro, sars, sars easyfile, tax sumbission, workmens compensation, audits, sdl, uif, ck, tax clearance certificates, accounting officer")]
        public ActionResult Training()
        {
            return View();
        }
    }
}
