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
        public ViewResult ContactUs(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                EmailProcessor emailProcessor = new EmailProcessor();
                emailProcessor.SendEmail(contact);

                return View(new ContactModel());
            }
            else
            {
                return View(contact);
            }
        }
    }
}
