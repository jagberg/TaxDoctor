using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TaxDoctor.Web
{
    public static class Config
    {
        public static string EmailSmtp
        {
            get
            {
                return ConfigurationManager.AppSettings["EmailSmtp"];
            }
        }

        public static int EmailSmtpPort
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["EmailSmtpPort"]);
            }
        }

        public static string EmailUsername
        {
            get
            {
                return ConfigurationManager.AppSettings["EmailUsername"];
            }
        }

        public static string EmailPassword
        {
            get
            {
                string password = ConfigurationManager.AppSettings["EmailPassword"];
                
                // Remove first 2 characters to slightly obfuscate the password. Using 128bit 
                // encryption would be better but this is fine for now.
                return password.Remove(0, 2);
            }
        }

        public static string EmailFrom
        {
            get
            {
                return ConfigurationManager.AppSettings["EmailFrom"];
            }
        }

        public static string EmailTo
        {
            get
            {
                return ConfigurationManager.AppSettings["EmailTo"];
            }
        }

        public static string EmailSubject
        {
            get
            {
                return ConfigurationManager.AppSettings["EmailSubject"];
            }
        }
    }
}