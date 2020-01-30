namespace IdentityApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr02 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posiions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PositionRolies",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        PositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.PositionId });
            
            CreateTable(
                "dbo.UserProfilies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserId = c.String(),
                        PositionId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProfilies");
            DropTable("dbo.PositionRolies");
            DropTable("dbo.Posiions");
        }
    }
}
