using Microsoft.EntityFrameworkCore.Migrations;

namespace EgdeBookingSystem.Data.Migrations
{
    public partial class locationUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Equipment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Equipment");
        }
    }
}
