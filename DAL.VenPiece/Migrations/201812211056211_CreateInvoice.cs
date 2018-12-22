namespace DAL.VenPiece.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInvoice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceId = c.Guid(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        DeadLineDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invoices");
        }
    }
}
