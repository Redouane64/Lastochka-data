using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lastochka.Data.Migrations
{
    public partial class AddLastModifiedDateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Offers",
                nullable: false,
                defaultValue: DateTime.UtcNow);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Offers");
        }
    }
}
