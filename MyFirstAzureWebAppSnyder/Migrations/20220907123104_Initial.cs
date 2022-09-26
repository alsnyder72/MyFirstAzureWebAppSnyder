﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstAzureWebAppSnyder.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "Name", "Rating", "Year" },
                values: new object[] { 2, "Wonder Woman", 3, 2017 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "Name", "Rating", "Year" },
                values: new object[] { 3, "Moonstruck", 4, 1988 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "id", "Name", "Rating", "Year" },
                values: new object[] { 4, "Cassablanca", 5, 1942 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
