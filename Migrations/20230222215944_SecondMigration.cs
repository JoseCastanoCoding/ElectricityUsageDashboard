using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectricityUsageDashboard.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Readings",
                columns: table => new
                {
                    ReadingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReadingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentReading = table.Column<int>(type: "int", nullable: false),
                    IsBilledReading = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readings", x => x.ReadingId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Readings");
        }
    }
}
