using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddExtraReferanceToCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Customers_CustomerId",
                table: "Extras");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Extras",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Extras_CustomerId",
                table: "Extras",
                newName: "IX_Extras_CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Cars_CarId",
                table: "Extras",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Cars_CarId",
                table: "Extras");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Extras",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Extras_CarId",
                table: "Extras",
                newName: "IX_Extras_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Customers_CustomerId",
                table: "Extras",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
