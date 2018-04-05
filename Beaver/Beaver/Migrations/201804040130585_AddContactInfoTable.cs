namespace Beaver.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContactInfoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        email = c.String(),
                        message = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactInfoes");
        }
    }
}
