using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaxDoctor.Web.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Apply meta attributes to action methods that use this.
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var pageTitle = filterContext.ActionDescriptor.GetCustomAttributes(typeof(PageTitleAttribute), false);
            if (pageTitle.Length == 1)
            {
                ViewData["PageTitle"] = ((PageTitleAttribute)(pageTitle[0])).Parameter;
            }

            var keywords = filterContext.ActionDescriptor.GetCustomAttributes(typeof(MetaKeywordsAttribute), false);
            if (keywords.Length == 1)
            {
                ViewData["MetaKeywords"] = ((MetaKeywordsAttribute)(keywords[0])).Parameter;
            }

            var description = filterContext.ActionDescriptor.GetCustomAttributes(typeof(MetaDescriptionAttribute), false);
            if (description.Length == 1)
            {
                ViewData["MetaDescription"] = ((MetaDescriptionAttribute)(description[0])).Parameter;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
