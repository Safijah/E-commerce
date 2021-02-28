using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class nova1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_AccountID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AspNetUsers_AccountID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_AccountID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Customer_AccountID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "AccountID",
                table: "Customer");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_ID",
                table: "Customer",
                column: "ID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AspNetUsers_ID",
                table: "Employee",
                column: "ID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_ID",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AspNetUsers_ID",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "AccountID",
                table: "Employee",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountID",
                table: "Customer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_AccountID",
                table: "Employee",
                column: "AccountID",
                unique: true,
                filter: "[AccountID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_AccountID",
                table: "Customer",
                column: "AccountID",
                unique: true,
                filter: "[AccountID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_AccountID",
                table: "Customer",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AspNetUsers_AccountID",
                table: "Employee",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
