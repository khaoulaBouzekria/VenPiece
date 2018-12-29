namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateClient : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderItems", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "Product_ProductId", "dbo.Products");
            DropIndex("dbo.OrderItems", new[] { "Order_OrderId" });
            DropIndex("dbo.OrderItems", new[] { "Product_ProductId" });
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "OrderDate");
            DropColumn("dbo.Orders", "ItemsTotal");
            DropColumn("dbo.Orders", "Phone");
            DropTable("dbo.OrderItems");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderId = c.Long(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Instructions = c.String(),
                        Order_OrderId = c.Guid(),
                        Product_ProductId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "Phone", c => c.String());
            AddColumn("dbo.Orders", "ItemsTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Orders", "Date");
            CreateIndex("dbo.OrderItems", "Product_ProductId");
            CreateIndex("dbo.OrderItems", "Order_OrderId");
            AddForeignKey("dbo.OrderItems", "Product_ProductId", "dbo.Products", "ProductId");
            AddForeignKey("dbo.OrderItems", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}
