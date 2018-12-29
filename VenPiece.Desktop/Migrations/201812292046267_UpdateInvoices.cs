namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateInvoices : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Invoice_InvoiceId", "dbo.Invoices");
            DropIndex("dbo.Orders", new[] { "Invoice_InvoiceId" });
            DropColumn("dbo.Orders", "Invoice_InvoiceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Invoice_InvoiceId", c => c.Guid());
            CreateIndex("dbo.Orders", "Invoice_InvoiceId");
            AddForeignKey("dbo.Orders", "Invoice_InvoiceId", "dbo.Invoices", "InvoiceId");
        }
    }
}
