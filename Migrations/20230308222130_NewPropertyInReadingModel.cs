using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityUsageDashboard.Migrations
{
    public partial class NewPropertyInReadingModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Readings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Readings");
        }
    }
}
