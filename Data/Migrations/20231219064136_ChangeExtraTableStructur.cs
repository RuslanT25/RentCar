using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class ChangeExtraTableStructur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BabySeat",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "DeliveryServiceRegions",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "Driver",
                table: "Extras");

            migrationBuilder.DropColumn(
                name: "GPS",
                table: "Extras");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Extras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Extras");

            migrationBuilder.AddColumn<bool>(
                name: "BabySeat",
                table: "Extras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DeliveryServiceRegions",
                table: "Extras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Driver",
                table: "Extras",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GPS",
                table: "Extras",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
