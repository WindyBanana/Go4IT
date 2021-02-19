using Microsoft.EntityFrameworkCore.Migrations;

namespace EgdeBookingSystem.Data.Migrations
{
    public partial class categoryFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Category_CategoryID",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_CategoryID",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Equipment");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Equipment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Equipment");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Equipment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_CategoryID",
                table: "Equipment",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Category_CategoryID",
                table: "Equipment",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
