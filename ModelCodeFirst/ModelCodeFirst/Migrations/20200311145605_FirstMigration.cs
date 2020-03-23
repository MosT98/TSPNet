using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelCodeFirst.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ClientId = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "Location", "Name", "Path" },
                values: new object[] { new Guid("4e9a7523-dc5e-45c9-ac3c-852c33c169df"), "Brasov", "Poza1", "E:\\IMPORTANT\\pozamunte.jpg" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ClientId", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { new Guid("f3927579-1069-47cb-9ec3-ea6fc233915a"), "ahalauca@gmail.com", "Andrei", "Halauca", "parola123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
