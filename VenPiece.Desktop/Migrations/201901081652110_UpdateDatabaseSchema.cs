namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabaseSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderId = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Instructions = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
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
            
            CreateTable(
                "dbo.InternalUserDatas",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        HashedPassword = c.String(),
                        Roles = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
            AddColumn("dbo.Clients", "Phone", c => c.String());
            AddColumn("dbo.Clients", "Email", c => c.String());
            AddColumn("dbo.Clients", "Street", c => c.String());
            AddColumn("dbo.Clients", "City", c => c.String());
            AddColumn("dbo.Clients", "Country", c => c.String());
            AddColumn("dbo.Clients", "Zip", c => c.String());
            AddColumn("dbo.Deliveries", "OrderId", c => c.Guid(nullable: false));
            AddColumn("dbo.Employees", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "ItemsTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "Phone", c => c.String());
            AddColumn("dbo.Orders", "ClientId", c => c.Guid(nullable: false));
            AddColumn("dbo.Products", "Description", c => c.String());
            CreateIndex("dbo.Orders", "ClientId");
            CreateIndex("dbo.Invoices", "InvoiceId");
            CreateIndex("dbo.Deliveries", "OrderId");
            AddForeignKey("dbo.Orders", "ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
            AddForeignKey("dbo.Invoices", "InvoiceId", "dbo.Orders", "OrderId");
            AddForeignKey("dbo.Deliveries", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: true);
            DropColumn("dbo.Employees", "Sexe");
            DropColumn("dbo.Orders", "Date");
            DropColumn("dbo.Products", "OutOfStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "OutOfStock", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employees", "Sexe", c => c.Int(nullable: false));
            DropForeignKey("dbo.Deliveries", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.DeliveryItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.DeliveryItems", "Delivery_DeliveryId", "dbo.Deliveries");
            DropForeignKey("dbo.OrderItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Invoices", "InvoiceId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropIndex("dbo.DeliveryItems", new[] { "Delivery_DeliveryId" });
            DropIndex("dbo.DeliveryItems", new[] { "ProductId" });
            DropIndex("dbo.Deliveries", new[] { "OrderId" });
            DropIndex("dbo.OrderItems", new[] { "ProductId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Invoices", new[] { "InvoiceId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Orders", "ClientId");
            DropColumn("dbo.Orders", "Phone");
            DropColumn("dbo.Orders", "ItemsTotal");
            DropColumn("dbo.Orders", "OrderDate");
            DropColumn("dbo.Employees", "Gender");
            DropColumn("dbo.Deliveries", "OrderId");
            DropColumn("dbo.Clients", "Zip");
            DropColumn("dbo.Clients", "Country");
            DropColumn("dbo.Clients", "City");
            DropColumn("dbo.Clients", "Street");
            DropColumn("dbo.Clients", "Email");
            DropColumn("dbo.Clients", "Phone");
            DropTable("dbo.InternalUserDatas");
            DropTable("dbo.DeliveryItems");
            DropTable("dbo.OrderItems");
        }
    }
}
