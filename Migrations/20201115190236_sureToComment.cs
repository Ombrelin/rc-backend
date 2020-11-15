using Microsoft.EntityFrameworkCore.Migrations;

namespace RencontreContemporainesAPI.Migrations
{
    public partial class sureToComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sure",
                table: "Ateliers");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Ateliers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Ateliers");

            migrationBuilder.AddColumn<bool>(
                name: "Sure",
                table: "Ateliers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
