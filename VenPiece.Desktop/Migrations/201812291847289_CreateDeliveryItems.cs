namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDeliveryItems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Instructions = c.String(),
                        Delivery_DeliveryId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deliveries", t => t.Delivery_DeliveryId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.Delivery_DeliveryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeliveryItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DeliveryItems", "Delivery_DeliveryId", "dbo.Deliveries");
            DropIndex("dbo.DeliveryItems", new[] { "Delivery_DeliveryId" });
            DropIndex("dbo.DeliveryItems", new[] { "ProductId" });
            DropTable("dbo.DeliveryItems");
        }
    }
}
