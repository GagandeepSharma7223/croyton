using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CroytonStoreFront.Database.Enums;

namespace CroytonStoreFront.Models
{
    public class CoreViewModel
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get { return DateTime.UtcNow; } set { }  }

        public DateTime UpdatedOn { get { return DateTime.UtcNow; } set { } }

        public Status Status { get { return Status.Active; } set { } }
    }
}