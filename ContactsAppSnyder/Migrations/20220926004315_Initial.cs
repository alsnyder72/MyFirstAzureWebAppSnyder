using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactsAppSnyder.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactId", "Address", "Name", "Phone" },
                values: new object[] { 1, "123 Sunshine Lane", "Christi", "123-456-7890" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactId", "Address", "Name", "Phone" },
                values: new object[] { 2, "346 Sunshine Lane", "Sam", "234-567-8901" });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "ContactId", "Address", "Name", "Phone" },
                values: new object[] { 3, "346 Sunshine Lane", "George", "234-567-8901" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
