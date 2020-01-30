namespace IdentityApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migr03 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Posiions", newName: "Positions");
            RenameTable(name: "dbo.PositionRolies", newName: "PositionRoles");
            RenameTable(name: "dbo.UserProfilies", newName: "UserProfiles");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserProfiles", newName: "UserProfilies");
            RenameTable(name: "dbo.PositionRoles", newName: "PositionRolies");
            RenameTable(name: "dbo.Positions", newName: "Posiions");
        }
    }
}
