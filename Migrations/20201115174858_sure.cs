using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RencontreContemporainesAPI.Migrations
{
    public partial class sure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Concerts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<bool>(
                name: "DateSure",
                table: "Concerts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LocationSure",
                table: "Concerts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sure",
                table: "Ateliers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateSure",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "LocationSure",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "Sure",
                table: "Ateliers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Concerts",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
