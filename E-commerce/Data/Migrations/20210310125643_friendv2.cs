using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class friendv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Friend_FriendID",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friend",
                table: "Friend");

            migrationBuilder.DropIndex(
                name: "IX_Customer_FriendID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "FriendID",
                table: "Customer");

            migrationBuilder.AlterColumn<string>(
                name: "E_mailFriends",
                table: "Friend",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Friend",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CustomerID",
                table: "Friend",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friend",
                table: "Friend",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Friend_CustomerID",
                table: "Friend",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Friend_Customer_CustomerID",
                table: "Friend",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friend_Customer_CustomerID",
                table: "Friend");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friend",
                table: "Friend");

            migrationBuilder.DropIndex(
                name: "IX_Friend_CustomerID",
                table: "Friend");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Friend");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Friend");

            migrationBuilder.AlterColumn<string>(
                name: "E_mailFriends",
                table: "Friend",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FriendID",
                table: "Customer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friend",
                table: "Friend",
                column: "E_mailFriends");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_FriendID",
                table: "Customer",
                column: "FriendID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Friend_FriendID",
                table: "Customer",
                column: "FriendID",
                principalTable: "Friend",
                principalColumn: "E_mailFriends",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
