namespace CroytonStoreFront.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedContactForm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactForm",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 200),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(maxLength: 40),
                        Website = c.String(maxLength: 100),
                        Message = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        UpdatedOn = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactForm");
        }
    }
}
