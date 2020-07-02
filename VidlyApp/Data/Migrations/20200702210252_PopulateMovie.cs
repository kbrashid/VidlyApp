using Microsoft.EntityFrameworkCore.Migrations;

namespace VidlyApp.Data.Migrations
{
    public partial class PopulateMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {            
            migrationBuilder.Sql("INSERT INTO Movies([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock]) VALUES(1, N'Hangover', 2, N'2020-07-02 16:23:05', N'2019-04-05 00:00:00', 10)");
            migrationBuilder.Sql("INSERT INTO Movies([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock]) VALUES(2, N'DieHard', 1, N'2020-07-02 16:23:30', N'2005-01-01 00:00:00', 10)");
            migrationBuilder.Sql("INSERT INTO Movies([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock]) VALUES(3, N'Sonar Din', 4, N'2020-07-02 16:24:02', N'2017-01-12 00:00:00', 12)");
            migrationBuilder.Sql("INSERT INTO Movies([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock]) VALUES(4, N'DebDas', 4, N'2020-07-02 16:24:42', N'2005-01-01 00:00:00', 12)");
            migrationBuilder.Sql("INSERT INTO Movies([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock]) VALUES(5, N'Hard Target', 5, N'2020-07-02 16:25:25', N'2005-01-01 00:00:00', 12)");
            migrationBuilder.Sql("INSERT INTO Movies([Id], [Name], [GenreId], [DateAdded], [ReleaseDate], [NumberInStock]) VALUES(6, N'Little Family', 3, N'2020-07-02 16:27:06', N'2019-04-05 00:00:00', 5)");
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
