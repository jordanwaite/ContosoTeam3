using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoTeam3.Migrations
{
    public partial class addFNameLname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Speaker");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Speaker");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Speaker",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
