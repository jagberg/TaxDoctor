using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaxDoctor.Web
{
    public enum WorkType
    {
        IndividualService,
        BusinessService,
        Training
    }

    public class ContactModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "* Please enter")]
        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "* Please enter")]
        //[EmailAddress]
        public string EmailAddress { get; set; }

        public WorkType RequiredWork { get; set; }

        [Required(ErrorMessage = "* Please enter")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}