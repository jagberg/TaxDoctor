using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class ContactController : Controller
    {
        public ViewResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(ContactModel contact)
        {
            if (string.IsNullOrWhiteSpace(contact.EmailAddress) && string.IsNullOrWhiteSpace(contact.PhoneNumber))
            {
                ModelState.AddModelError("EmailAddress", "Please enter phone or email");
                ModelState.AddModelError("PhoneNumber", "Please enter phone or email");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    EmailProcessor emailProcessor = new EmailProcessor();
                    emailProcessor.SendEmail(contact);
                }
                catch (System.Net.Mail.SmtpException smtpEx)
                {
                    TempData["EmailException"] = "Apologies, we're unable to send your contact details to us at present. Please call or email us instead.";
                    //TODO: Log exception
                    
                    return PartialView(contact);
                }

                TempData["ContactUsSuccessMessage"] = new HtmlString(string.Format("Thanks <b>{0}</b>. We will be in touch soon...", contact.Name));
                
                return RedirectToAction("ContactUs");
            }
            else
            {
                return PartialView(contact);
            }
        }
    }
}
