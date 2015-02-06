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

        [EmailAddress(ErrorMessage = "* Invalid email")]
        //[Required(ErrorMessage = "* Please enter")]
        public string EmailAddress { get; set; }

        public WorkType RequiredWork { get; set; }

        [Required(ErrorMessage = "* Please enter")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        /// <summary>
        /// If entered then the message is spam
        /// </summary>
        public string SpamText { get; set; }

        public bool IsSpam
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.SpamText);
            }
        }


        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(this.EmailAddress) && string.IsNullOrWhiteSpace(this.PhoneNumber))
            {
                return false;
            }
            return true;
        }
    }
}