using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class nova2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_City_CityID",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditCard_Customer_CustomerID1",
                table: "CreditCard");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryOfPayments_Customer_CustomerID1",
                table: "HistoryOfPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemCostHistory_ItemCostHistoryID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Employee_EmployeeID1",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Customer_CustomerID1",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCart_CustomerID1",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_EmployeeID1",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Item_ItemCostHistoryID",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_HistoryOfPayments_CustomerID1",
                table: "HistoryOfPayments");

            migrationBuilder.DropIndex(
                name: "IX_CreditCard_CustomerID1",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "EmployeeID1",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "ItemCostHistoryID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "HistoryOfPayments");

            migrationBuilder.DropColumn(
                name: "CustomerID1",
                table: "CreditCard");

            migrationBuilder.RenameColumn(
                name: "CityID",
                table: "Branch",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Branch_CityID",
                table: "Branch",
                newName: "IX_Branch_CityId");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "ShoppingCart",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeID",
                table: "Purchase",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "ItemCostHistory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "HistoryOfPayments",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "CreditCard",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CustomerID",
                table: "ShoppingCart",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_EmployeeID",
                table: "Purchase",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemCostHistory_ItemID",
                table: "ItemCostHistory",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryOfPayments_CustomerID",
                table: "HistoryOfPayments",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCard_CustomerID",
                table: "CreditCard",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_City_CityId",
                table: "Branch",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCard_Customer_CustomerID",
                table: "CreditCard",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryOfPayments_Customer_CustomerID",
                table: "HistoryOfPayments",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCostHistory_Item_ItemID",
                table: "ItemCostHistory",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Employee_EmployeeID",
                table: "Purchase",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Customer_CustomerID",
                table: "ShoppingCart",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_City_CityId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_CreditCard_Customer_CustomerID",
                table: "CreditCard");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryOfPayments_Customer_CustomerID",
                table: "HistoryOfPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCostHistory_Item_ItemID",
                table: "ItemCostHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Employee_EmployeeID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Customer_CustomerID",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCart_CustomerID",
                table: "ShoppingCart");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_EmployeeID",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_ItemCostHistory_ItemID",
                table: "ItemCostHistory");

            migrationBuilder.DropIndex(
                name: "IX_HistoryOfPayments_CustomerID",
                table: "HistoryOfPayments");

            migrationBuilder.DropIndex(
                name: "IX_CreditCard_CustomerID",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "ItemCostHistory");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Branch",
                newName: "CityID");

            migrationBuilder.RenameIndex(
                name: "IX_Branch_CityId",
                table: "Branch",
                newName: "IX_Branch_CityID");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "ShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerID1",
                table: "ShoppingCart",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "Purchase",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeID1",
                table: "Purchase",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCostHistoryID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "HistoryOfPayments",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerID1",
                table: "HistoryOfPayments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "CreditCard",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerID1",
                table: "CreditCard",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_CustomerID1",
                table: "ShoppingCart",
                column: "CustomerID1");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_EmployeeID1",
                table: "Purchase",
                column: "EmployeeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemCostHistoryID",
                table: "Item",
                column: "ItemCostHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryOfPayments_CustomerID1",
                table: "HistoryOfPayments",
                column: "CustomerID1");

            migrationBuilder.CreateIndex(
                name: "IX_CreditCard_CustomerID1",
                table: "CreditCard",
                column: "CustomerID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_City_CityID",
                table: "Branch",
                column: "CityID",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CreditCard_Customer_CustomerID1",
                table: "CreditCard",
                column: "CustomerID1",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryOfPayments_Customer_CustomerID1",
                table: "HistoryOfPayments",
                column: "CustomerID1",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemCostHistory_ItemCostHistoryID",
                table: "Item",
                column: "ItemCostHistoryID",
                principalTable: "ItemCostHistory",
                principalColumn: "ItemCostHistoryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Employee_EmployeeID1",
                table: "Purchase",
                column: "EmployeeID1",
                principalTable: "Employee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Customer_CustomerID1",
                table: "ShoppingCart",
                column: "CustomerID1",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
