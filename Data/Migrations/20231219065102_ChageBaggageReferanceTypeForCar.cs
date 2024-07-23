using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ChageBaggageReferanceTypeForCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Baggages_BaggageId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_BaggageId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BaggageCount",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BaggageId",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Baggages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Baggages_CarId",
                table: "Baggages",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Baggages_Cars_CarId",
                table: "Baggages",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baggages_Cars_CarId",
                table: "Baggages");

            migrationBuilder.DropIndex(
                name: "IX_Baggages_CarId",
                table: "Baggages");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Baggages");

            migrationBuilder.AddColumn<short>(
                name: "BaggageCount",
                table: "Cars",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<int>(
                name: "BaggageId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BaggageId",
                table: "Cars",
                column: "BaggageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Baggages_BaggageId",
                table: "Cars",
                column: "BaggageId",
                principalTable: "Baggages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
