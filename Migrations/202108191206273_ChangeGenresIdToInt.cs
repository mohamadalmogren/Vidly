namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenresIdToInt : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            DropColumn("dbo.Movies", "GenresId");
            RenameColumn(table: "dbo.Movies", name: "Genres_Id", newName: "GenresId");
            AlterColumn("dbo.Movies", "GenresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenresId");


        }
        
        public override void Down()
        {
            DropIndex("dbo.Movies", new[] { "GenresId" });
            AlterColumn("dbo.Movies", "GenresId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Movies", name: "GenresId", newName: "Genres_Id");
            AddColumn("dbo.Movies", "GenresId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "Genres_Id");
        }
    }
}
