using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CroytonStoreFront.Database;

namespace CroytonStoreFront.Models
{
    public class ContactFormViewModel : CoreViewModel
    {
        //[MaxLength(100, ErrorMessage = "limit exceeds")]
        [Required(ErrorMessage = "cannot leave blank")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "cannot leave blank")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [RegularExpression(ValidationConstants.UrlPattern)]
        [Display(Name="Organization Web Site")]
        public string Website { get; set; }


        [Required(ErrorMessage = "cannot leave blank")]
        public string Message { get; set; }


    }
}