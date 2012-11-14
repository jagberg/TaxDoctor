using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web
{
    public class EmailProcessor
    {
        public void SendEmail(ContactModel contact)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("taxdoctorsa@gmail.com", "Casper#73"),
                EnableSsl = true
            };
            client.Send("taxdoctorsa@gmail.com", "jagberg@gmail.com", "test", GetContactEmailBody(contact));
           
        }

        private string GetContactEmailBody(ContactModel contact)
        {
            StringBuilder body = new StringBuilder();

            body.AppendLine(string.Format("Name: {0}", contact.Name));
            body.AppendLine(string.Format("Email: {0}", contact.EmailAddress));
            body.AppendLine(string.Format("Phone Number: {0}", contact.PhoneNumber));
            //body.Append(string.Format("Required Work: {0}", contact.RequiredWork));
            body.Append(string.Format("Comment: {0}", contact.Comment));

            return body.ToString();
        }
    }
}
