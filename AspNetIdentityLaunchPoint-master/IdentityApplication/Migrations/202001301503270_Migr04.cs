namespace IdentityApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr04 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PositionRoles");
            AlterColumn("dbo.PositionRoles", "RoleId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserProfiles", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserProfiles", "PositionId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PositionRoles", new[] { "RoleId", "PositionId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PositionRoles");
            AlterColumn("dbo.UserProfiles", "PositionId", c => c.String());
            AlterColumn("dbo.UserProfiles", "UserId", c => c.String());
            AlterColumn("dbo.PositionRoles", "RoleId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.PositionRoles", new[] { "RoleId", "PositionId" });
        }
    }
}
