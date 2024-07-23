using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddDatesToCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Extras_Customers_CustomerId",
                table: "Extras");

            migrationBuilder.DropIndex(
                name: "IX_Extras_CustomerId",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Extras");

            migrationBuilder.AddColumn<double>(
                name: "Payment",
                table: "Customers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RentDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RentDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Extras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Extras_CustomerId",
                table: "Extras",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Extras_Customers_CustomerId",
                table: "Extras",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
