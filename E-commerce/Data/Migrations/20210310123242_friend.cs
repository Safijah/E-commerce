using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class friend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                table: "Item");

            migrationBuilder.AddColumn<string>(
                name: "FriendID",
                table: "Customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Friend",
                columns: table => new
                {
                    E_mailFriends = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.E_mailFriends);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Friend_FriendID",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.DropIndex(
                name: "IX_Customer_FriendID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "FriendID",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
