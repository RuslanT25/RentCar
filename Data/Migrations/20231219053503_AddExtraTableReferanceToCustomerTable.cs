using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class AddExtraTableReferanceToCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
