using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class changeforcard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpDate",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "Expyear",
                table: "CreditCard");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "CreditCard",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Cvc",
                table: "CreditCard",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "CreditCard",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "CreditCard",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cvc",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "CreditCard");

            migrationBuilder.AlterColumn<int>(
                name: "CardNumber",
                table: "CreditCard",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExpDate",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Expyear",
                table: "CreditCard",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
