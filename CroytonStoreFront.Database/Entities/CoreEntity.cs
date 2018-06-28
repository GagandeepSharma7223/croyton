using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CroytonStoreFront.Database.Enums;

namespace CroytonStoreFront.Database.Entities
{
    public abstract class CoreEntity
    {
        [Key, Column("Id")]
        public int Id { get; set; }

        [Column("CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [Column("UpdatedOn")]
        public DateTime UpdatedOn { get; set; }

        [Column("Status")]
        public Status Status { get; set; }
    }
}
