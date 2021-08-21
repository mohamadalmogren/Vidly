namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetidToIdInMembershipType : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Customers", new[] { "MembershipType_id" });
            CreateIndex("dbo.Customers", "MembershipType_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            CreateIndex("dbo.Customers", "MembershipType_id");
        }
    }
}
