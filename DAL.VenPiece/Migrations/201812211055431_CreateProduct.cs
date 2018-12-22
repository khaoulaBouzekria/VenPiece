namespace DAL.VenPiece.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Guid(nullable: false),
                        Designation = c.String(),
                        price = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        OutOfStock = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
