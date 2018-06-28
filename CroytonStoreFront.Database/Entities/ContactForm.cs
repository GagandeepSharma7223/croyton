using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CroytonStoreFront.Database.Entities
{
    [Table("ContactForm")]
    public class ContactForm : CoreEntity 
    {
        [MaxLength(200)]
        [Required]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MaxLength(40)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Website { get; set; }

        [Required]
        public string Message { get; set; }

    }
}
