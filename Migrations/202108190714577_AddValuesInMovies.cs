namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesInMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,GenreId, DateAdded, ReleaseDate, NumberInStock, Genres_Id)" +
                " VALUES ('Hangover', 1, 8/14/2021, 3/5/2015, 5,1)");

            Sql("INSERT INTO Movies (Name,GenreId, DateAdded, ReleaseDate, NumberInStock, Genres_Id)" +
                " VALUES ('Die Hard', 2, 8/15/2021, 8/25/2010, 8,2)");

            Sql("INSERT INTO Movies (Name,GenreId, DateAdded, ReleaseDate, NumberInStock, Genres_Id)" +
                " VALUES ('The Terminator', 3, 8/11/2021, 1/1/2020, 2,3)");

            Sql("INSERT INTO Movies (Name,GenreId, DateAdded, ReleaseDate, NumberInStock, Genres_Id)" +
                " VALUES ('Toy Story', 4, 8/18/2021, 4/1/2019, 8,4)");

            Sql("INSERT INTO Movies (Name,GenreId, DateAdded, ReleaseDate, NumberInStock, Genres_Id)" +
                " VALUES ('Titanic', 1, 8/20/2021, 1/3/2015, 10,1)");


        }

        public override void Down()
        {
        }
    }
}
