namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDeliveries : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Deliveries", "OrderId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Deliveries", "OrderId");
            AddForeignKey("dbo.Deliveries", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deliveries", "OrderId", "dbo.Orders");
            DropIndex("dbo.Deliveries", new[] { "OrderId" });
            DropColumn("dbo.Deliveries", "OrderId");
        }
    }
}
