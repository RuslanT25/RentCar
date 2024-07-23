using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ChangeCustomerTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Extras_ExtraId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ExtraId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ExtraId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Extras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Extras_CustomerId",
                table: "Extras",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CarId",
                table: "Customers",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Cars_CarId",
                table: "Customers",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Customers_CustomerId",
                table: "Extras",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Cars_CarId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Customers_CustomerId",
                table: "Extras");

            migrationBuilder.DropIndex(
                name: "IX_Extras_CustomerId",
                table: "Extras");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CarId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "ExtraId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ExtraId",
                table: "Customers",
                column: "ExtraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Extras_ExtraId",
                table: "Customers",
                column: "ExtraId",
                principalTable: "Extras",
                principalColumn: "Id");
        }
    }
}
