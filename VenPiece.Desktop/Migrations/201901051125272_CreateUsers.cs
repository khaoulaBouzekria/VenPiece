namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InternalUserDatas",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        HashedPassword = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.InternalUserDatas");
        }
    }
}
