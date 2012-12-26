using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxDoctor.Web
{
    public enum ErrorType
    {
        Information,
        Error
    }

    public interface ILogger
    {
        void Log(string message, ErrorType errType);
    }

    public class Logger : ILogger
    {
        private static readonly ILog log = log4net.LogManager.GetLogger("TaxDoctorLogger");

        public Logger()
        {
        }

        internal static void Configure()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        public void Log(string message, ErrorType errType)
        {
            try
            {
                if (errType == ErrorType.Error)
                {
                    log.Error(message);
                }
                else
                {
                    log.Info(message);
                }
            }
            catch
            {
                // If you cant log an exception then nothing else you can do.
            }
        }
    }
}