using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class forimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "ItemImage");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "ItemImage",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ItemImage");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "ItemImage",
                type: "nvarchar(100)",
                nullable: true);
        }
    }
}
