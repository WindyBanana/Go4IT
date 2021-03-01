using Microsoft.EntityFrameworkCore.Migrations;

namespace EgdeBookingSystem.Data.Migrations
{
    public partial class updatedBookingFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Booking");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Booking",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
