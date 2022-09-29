using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoTeam3.Migrations
{
    public partial class addDateDetailsNumSeatsImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Session",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Session",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumSeats",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "NumSeats",
                table: "Session");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Session",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
