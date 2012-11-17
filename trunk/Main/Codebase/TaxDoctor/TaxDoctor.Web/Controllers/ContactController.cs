using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class ContactController : Controller
    {
        public PartialViewResult ContactUs()
        {
            return PartialView();
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
                    //emailProcessor.SendEmail(contact);
                }
                catch (System.Net.Mail.SmtpException smtpEx)
                {
                    TempData["EmailException"] = "Apologies, we're unable to send your contact details to us at present. Please call or email us instead.";
                    //TODO: Log exception
                    //ModelState.AddModelError("all", "Apologies, we're unable to send your contact details at present. Please call or email instead.");

                    return PartialView(contact);
                }

                return RedirectToAction("ContactUs");
                //return RedirectToAction("ThankYou", new { name = contact.Name });
            }
            else
            {
                return PartialView(contact);
                //return View("ContactUs");
            }
        }

        public ActionResult ThankYou(string name)
        {
            return View((object)name);
        }
    }
}
