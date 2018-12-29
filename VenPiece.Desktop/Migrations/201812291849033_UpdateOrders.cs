namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Client_ClientId", "dbo.Clients");
            DropIndex("dbo.Orders", new[] { "Client_ClientId" });
            RenameColumn(table: "dbo.Orders", name: "Client_ClientId", newName: "ClientId");
            AddColumn("dbo.Orders", "OrderDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "ItemsTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "Phone", c => c.String());
            AddColumn("dbo.Orders", "Invoice_InvoiceId", c => c.Guid());
            AlterColumn("dbo.Orders", "ClientId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Orders", "ClientId");
            CreateIndex("dbo.Orders", "Invoice_InvoiceId");
            AddForeignKey("dbo.Orders", "Invoice_InvoiceId", "dbo.Invoices", "InvoiceId");
            AddForeignKey("dbo.Orders", "ClientId", "dbo.Clients", "ClientId", cascadeDelete: true);
            DropColumn("dbo.Orders", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Orders", "Invoice_InvoiceId", "dbo.Invoices");
            DropIndex("dbo.Orders", new[] { "Invoice_InvoiceId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            AlterColumn("dbo.Orders", "ClientId", c => c.Guid());
            DropColumn("dbo.Orders", "Invoice_InvoiceId");
            DropColumn("dbo.Orders", "Phone");
            DropColumn("dbo.Orders", "ItemsTotal");
            DropColumn("dbo.Orders", "OrderDate");
            RenameColumn(table: "dbo.Orders", name: "ClientId", newName: "Client_ClientId");
            CreateIndex("dbo.Orders", "Client_ClientId");
            AddForeignKey("dbo.Orders", "Client_ClientId", "dbo.Clients", "ClientId");
        }
    }
}
