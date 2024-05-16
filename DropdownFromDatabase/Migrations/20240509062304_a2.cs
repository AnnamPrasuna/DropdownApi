using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DropdownFromDatabase.Migrations
{
    public partial class a2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechnologyName",
                table: "Technology",
                newName: "TechName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TechName",
                table: "Technology",
                newName: "TechnologyName");
        }
    }
}
