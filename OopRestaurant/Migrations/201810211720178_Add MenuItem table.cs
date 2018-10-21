namespace OopRestaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMenuItemtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MenuItems");
        }
    }
}
