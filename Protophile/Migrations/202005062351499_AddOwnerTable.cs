namespace Protophile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOwnerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Profil = c.String(),
                        Avatar = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
        }
    }
}
