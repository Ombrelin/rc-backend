using Microsoft.EntityFrameworkCore.Migrations;

namespace RencontreContemporainesAPI.Migrations
{
    public partial class dateformat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateFormat",
                table: "Concerts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateFormat",
                table: "Concerts");
        }
    }
}
