using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoTeam3.Migrations
{
    public partial class adddetailstoSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Session",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Session",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Session");
        }
    }
}
