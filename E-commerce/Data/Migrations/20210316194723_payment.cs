using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Month",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "CreditCard");

            migrationBuilder.AddColumn<int>(
                name: "ExpMonth",
                table: "CreditCard",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpYear",
                table: "CreditCard",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Check",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Check",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Check",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpMonth",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "ExpYear",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Check");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Check");

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<float>(
                name: "Discount",
                table: "Check",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
