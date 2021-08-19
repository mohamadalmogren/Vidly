namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenresModelAndAddAtrebuteInMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        GenreId = c.Byte(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        NumberInStock = c.Byte(nullable: false),
                        Genres_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genres_Id, cascadeDelete: true)
                .Index(t => t.Genres_Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
}
