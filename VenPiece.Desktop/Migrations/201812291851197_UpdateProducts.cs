namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            DropColumn("dbo.Products", "OutOfStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "OutOfStock", c => c.Boolean(nullable: false));
            DropColumn("dbo.Products", "Description");
        }
    }
}
