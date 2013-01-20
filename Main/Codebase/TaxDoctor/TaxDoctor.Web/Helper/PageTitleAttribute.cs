using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxDoctor.Web
{
    public class PageTitleAttribute : Attribute
    {
        private readonly string _parameter;

        public PageTitleAttribute(string parameter)
        {
            _parameter = parameter;
        }

        public string Parameter
        {
            get { return _parameter; }
        }
    }
}