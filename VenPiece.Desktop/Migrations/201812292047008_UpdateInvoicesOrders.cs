namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInvoicesOrders : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Invoices", "InvoiceId");
            AddForeignKey("dbo.Invoices", "InvoiceId", "dbo.Orders", "OrderId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "InvoiceId", "dbo.Orders");
            DropIndex("dbo.Invoices", new[] { "InvoiceId" });
        }
    }
}
