using Microsoft.EntityFrameworkCore.Migrations;

namespace Thaco.Peugeot.Migrations
{
    public partial class UpGrade2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityId",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxCode",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IdentityId",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TaxCode",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Customer");
        }
    }
}
