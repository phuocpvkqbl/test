using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Thaco.Peugeot.Migrations
{
    public partial class UpGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "periodId",
                table: "Document",
                newName: "PeriodId");

            migrationBuilder.AddColumn<long>(
                name: "CreatedDate1",
                table: "Review",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "News",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "News",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate1",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "News");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "News");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "News");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "News");

            migrationBuilder.RenameColumn(
                name: "PeriodId",
                table: "Document",
                newName: "periodId");
        }
    }
}
