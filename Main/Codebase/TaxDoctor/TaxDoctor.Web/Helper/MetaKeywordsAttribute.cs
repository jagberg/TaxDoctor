using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxDoctor.Web
{
    public class MetaKeywordsAttribute : Attribute
    {
        private readonly string _parameter;

        public MetaKeywordsAttribute(string parameter)
        {
            _parameter = parameter;
        }

        public string Parameter
        {
            get { return _parameter; }
        }
    }
}