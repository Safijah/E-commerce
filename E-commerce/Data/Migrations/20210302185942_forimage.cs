using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class forimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemImage",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemImage_Item_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemImage_ItemID",
                table: "ItemImage",
                column: "ItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemImage");
        }
    }
}
