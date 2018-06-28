using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CroytonStoreFront.Database.Entities;
namespace CroytonStoreFront.Database
{
    public class CroytonDbContext : DbContext
    {
        public static CroytonDbContext Create() => new CroytonDbContext();

        public CroytonDbContext()
            : base("CroytonConnectionString")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<ContactForm> ContactForms { get; set; }
    }
}
