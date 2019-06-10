using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class ServicesController : BaseController
    {
        [PageTitle("Accounting and Tax incl. payroll, financial statements")]
        [MetaDescription("Accounting and Tax services incl. payroll, financial statements and SARS submissions through easyFile | Accountant in Johannesburg area")]
        [MetaKeywords("accounting, accountant, financial statements, payroll services, payroll outsourcing company, Accounting firms Johannesburg, taxation consultants")]
        public ActionResult Accounting()
        {
            return View();
        }

        [PageTitle("Affordable accounting, bookkeeping, payroll and tax returns")]
        [MetaDescription("We offer an affordable service for all your tax concerns and including accounting, bookkeeping, training and personal tax returns.")]
        [MetaKeywords("tax, bookkeeping, bookkeeper, payroll, paye, irp5, irp6, it12, it14, emp201, emp501, vat201, cashflow, financial statements, company formations, annual returns, cipc, cipro, sars, sars easyfile, tax sumbission, workmens compensation, audits, quickbooks, pastel payroll, excel, sdl, uif, ck, tax clearance certificates, accounting officer")]
        public ActionResult OurServices(string message)
        {
            ViewBag.Message = message;

            return View();
        }

        [PageTitle("Affordable bookkeeping, payroll and tax returns")]
        [MetaDescription("Bookkeeping service incl. Sars easyFile, Cipro registrations | Bookkeeper in Johannesburg area")]
        [MetaKeywords("tax, bookkeeping, bookkeeper, bookkeeping companies Johannesburg, Bookkeepers Johannesburg, payroll, paye, irp5, irp6, it12, it14, emp201, emp501, vat201, cipc, cipro, sars, sars easyfile, tax sumbission, workmens compensation, sdl, uif, tax clearance certificates")]
        public ActionResult Bookkeeping()
        {
            return View();
        }

        [PageTitle("Financial statements for loans and cashflow management")]
        [MetaDescription("Submission of IT14 to SARS, Directors and Accounting Officer / Auditor reports, Balance sheet, Income statement, Fixed assets schedule, Cashflows")]
        [MetaKeywords("sars, it12, loans, cashflow, financial statements, company formations, audits, accounting officer")]
        public ActionResult FinancialStatements()
        {
            return View();
        }

        [PageTitle("Cheap business formation | Company registration")]
        [MetaDescription("We take you through the process of name reservation, Company registration, Registering for workmens compensation, UIF registration, Tax registration eg. PAYE, VAT, Company Tax")]
        [MetaKeywords("company registration, business registration, company formation, business, shelf, online business registration, online company registration, bee registration, tenders, tender registration, bee, moi, share register, shares, directors, shareholders, ngo, bee funding, dti, cipc,cipro, registrar of companies, government grants, government business funding")]
        public ActionResult CompanyFormations()
        {
            return View();
        }

        [PageTitle("Affordable PAYE payroll service for your business")]
        [MetaDescription("Affordable payroll service incl. payslips, submission to SARS of EMP201, UIF and SDL, Annual/Bi-Annual EMP501 reconciliations, Provision of IRP5/IT3(a) for each employee")]
        [MetaKeywords("bookkeeping, bookkeeper, payroll, paye, irp5, irp6, it12, it14, emp201, emp501, vat201, sars, sars easyfile, tax sumbission, workmens compensation, sdl, uif, ck")]
        public ActionResult Payroll()
        {
            return View();
        }

        [PageTitle("Affordable tax services and submissions in Jhb area")]
        [MetaDescription("Affordable Tax submission and preparation. Submission to SARS easyFile. IT14 - Annual submission of company details incl. CK, VAT, PAYE, Tax practitioner details, VAT201, VAT Audits, EMP201 - PAYE, SDL, UIF returns and payments, IRP6, Tax Clearance Certificates")]
        [MetaKeywords("tax, bookkeeping, bookkeeper, payroll, paye, irp5, irp6, it12, it14, emp201, emp501, vat201, annual returns, sars, sars easyfile, tax sumbission, workmens compensation, audits, sdl, uif, ck, tax clearance certificates, accounting officer")]
        public ActionResult TaxServices()
        {
            return View();
        }

        [PageTitle("Assistance with bank loan application in Jhb area")]
        [MetaDescription("If youre struggling to get a bank loan application we can help. We have many successful clients who have been approved a loan even with strict bank regulations currently in place.")]
        [MetaKeywords("bank loan applications, bank loan, loans, cashflow, financial statements, company formations, audits, accounting officer")]
        public ActionResult BankLoanApplications()
        {
            return View();
        }

        [PageTitle("Prices for accounting, bookkeeping, payroll, tax returns")]
        [MetaDescription("Our affordable prices for services including accounting, bookkeeping, training, personal and business tax returns.")]
        [MetaKeywords("tax prices, prices, accounting prices, bookkeeping prices, tax, bookkeeping, bookkeeper, payroll, paye, irp5, irp6, it12, it14, emp201, emp501, vat201, cashflow, financial statements, company formations, annual returns, cipc, cipro, sars, sars easyfile, tax sumbission, workmens compensation, audits, quickbooks, pastel payroll, excel, sdl, uif, ck, tax clearance certificates, accounting officer")]
        public ActionResult Prices()
        {
            return View();
        }

    }
}
