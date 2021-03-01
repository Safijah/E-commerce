using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class nova4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_City_CityId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_Coupon_CouponID",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_PaymentMethod_PaymentMethodID",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryOfPayments_Check_CheckID",
                table: "HistoryOfPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Branch_BranchID",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_ItemSize_ItemSizeID",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_BrandCategory_BrandCategoryID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_GenderCategory_GenderCategoryID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_SubCategory_SubCategoryID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCostHistory_Item_ItemID",
                table: "ItemCostHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSize_Item_ItemID",
                table: "ItemSize");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSize_Size_SizeID",
                table: "ItemSize");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ItemSize_ItemSizeID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShoppingCart_ShoppingCartID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Branch_BranchID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_ItemSize_ItemSizeID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Branch_BranchID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Check_CheckID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_CreditCard_CreditCardID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_CategoryID",
                table: "SubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Branch_BranchID",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_ItemSize_ItemSizeID",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemSize",
                table: "ItemSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_GenderCategoryID",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_SubCategoryID",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoryOfPayments",
                table: "HistoryOfPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenderCategory",
                table: "GenderCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Check",
                table: "Check");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrandCategory",
                table: "BrandCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "WarehouseID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "SubCategoryID",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "SizeID",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "ShoppingCartID",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "PurchaseID",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "PaymentMethodID",
                table: "PaymentMethod");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ItemSizeID",
                table: "ItemSize");

            migrationBuilder.DropColumn(
                name: "ItemCostHistoryID",
                table: "ItemCostHistory");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "GenderCategoryID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "SubCategoryID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "InventoryID",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "HistoryOfPaymentsID",
                table: "HistoryOfPayments");

            migrationBuilder.DropColumn(
                name: "GenderCategoryID",
                table: "GenderCategory");

            migrationBuilder.DropColumn(
                name: "CreditCardID",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "CouponID",
                table: "Coupon");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CheckID",
                table: "Check");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "BrandCategoryID",
                table: "BrandCategory");

            migrationBuilder.DropColumn(
                name: "BranchID",
                table: "Branch");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Warehouse",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "SubCategory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Size",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Size",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ShoppingCart",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Purchase",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "PaymentMethod",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Order",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ItemSize",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "ItemCostHistory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Item",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GenderSubCategoryID",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Inventory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "HistoryOfPayments",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "GenderCategory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "CreditCard",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Coupon",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "City",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Check",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Category",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "BrandCategory",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Branch",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemSize",
                table: "ItemSize",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoryOfPayments",
                table: "HistoryOfPayments",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenderCategory",
                table: "GenderCategory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Check",
                table: "Check",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrandCategory",
                table: "BrandCategory",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "GenderSubCategory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryID = table.Column<int>(nullable: false),
                    GenderCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderSubCategory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GenderSubCategory_GenderCategory_GenderCategoryID",
                        column: x => x.GenderCategoryID,
                        principalTable: "GenderCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GenderSubCategory_SubCategory_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "SubCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Size_CategoryID",
                table: "Size",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_GenderSubCategoryID",
                table: "Item",
                column: "GenderSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_GenderSubCategory_GenderCategoryID",
                table: "GenderSubCategory",
                column: "GenderCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_GenderSubCategory_SubCategoryID",
                table: "GenderSubCategory",
                column: "SubCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_City_CityId",
                table: "Branch",
                column: "CityId",
                principalTable: "City",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Coupon_CouponID",
                table: "Check",
                column: "CouponID",
                principalTable: "Coupon",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Check_PaymentMethod_PaymentMethodID",
                table: "Check",
                column: "PaymentMethodID",
                principalTable: "PaymentMethod",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryOfPayments_Check_CheckID",
                table: "HistoryOfPayments",
                column: "CheckID",
                principalTable: "Check",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Branch_BranchID",
                table: "Inventory",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_ItemSize_ItemSizeID",
                table: "Inventory",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_BrandCategory_BrandCategoryID",
                table: "Item",
                column: "BrandCategoryID",
                principalTable: "BrandCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_GenderSubCategory_GenderSubCategoryID",
                table: "Item",
                column: "GenderSubCategoryID",
                principalTable: "GenderSubCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCostHistory_Item_ItemID",
                table: "ItemCostHistory",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSize_Item_ItemID",
                table: "ItemSize",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSize_Size_SizeID",
                table: "ItemSize",
                column: "SizeID",
                principalTable: "Size",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ItemSize_ItemSizeID",
                table: "Order",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ShoppingCart_ShoppingCartID",
                table: "Order",
                column: "ShoppingCartID",
                principalTable: "ShoppingCart",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Branch_BranchID",
                table: "Purchase",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_ItemSize_ItemSizeID",
                table: "Purchase",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Branch_BranchID",
                table: "ShoppingCart",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Check_CheckID",
                table: "ShoppingCart",
                column: "CheckID",
                principalTable: "Check",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_CreditCard_CreditCardID",
                table: "ShoppingCart",
                column: "CreditCardID",
                principalTable: "CreditCard",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Size_Category_CategoryID",
                table: "Size",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_CategoryID",
                table: "SubCategory",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Branch_BranchID",
                table: "Warehouse",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_ItemSize_ItemSizeID",
                table: "Warehouse",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_City_CityId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_Coupon_CouponID",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_Check_PaymentMethod_PaymentMethodID",
                table: "Check");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryOfPayments_Check_CheckID",
                table: "HistoryOfPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Branch_BranchID",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_ItemSize_ItemSizeID",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_BrandCategory_BrandCategoryID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_GenderSubCategory_GenderSubCategoryID",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemCostHistory_Item_ItemID",
                table: "ItemCostHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSize_Item_ItemID",
                table: "ItemSize");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemSize_Size_SizeID",
                table: "ItemSize");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ItemSize_ItemSizeID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShoppingCart_ShoppingCartID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Branch_BranchID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_ItemSize_ItemSizeID",
                table: "Purchase");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Branch_BranchID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_Check_CheckID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_CreditCard_CreditCardID",
                table: "ShoppingCart");

            migrationBuilder.DropForeignKey(
                name: "FK_Size_Category_CategoryID",
                table: "Size");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategory_Category_CategoryID",
                table: "SubCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_Branch_BranchID",
                table: "Warehouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Warehouse_ItemSize_ItemSizeID",
                table: "Warehouse");

            migrationBuilder.DropTable(
                name: "GenderSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropIndex(
                name: "IX_Size_CategoryID",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemSize",
                table: "ItemSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_GenderSubCategoryID",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoryOfPayments",
                table: "HistoryOfPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GenderCategory",
                table: "GenderCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Check",
                table: "Check");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BrandCategory",
                table: "BrandCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Warehouse");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Size");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ShoppingCart");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "PaymentMethod");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ItemSize");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ItemCostHistory");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "GenderSubCategoryID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "HistoryOfPayments");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "GenderCategory");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "CreditCard");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Coupon");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "City");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Check");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "BrandCategory");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Branch");

            migrationBuilder.AddColumn<int>(
                name: "WarehouseID",
                table: "Warehouse",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryID",
                table: "SubCategory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SizeID",
                table: "Size",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartID",
                table: "ShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseID",
                table: "Purchase",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethodID",
                table: "PaymentMethod",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemSizeID",
                table: "ItemSize",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemCostHistoryID",
                table: "ItemCostHistory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GenderCategoryID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InventoryID",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "HistoryOfPaymentsID",
                table: "HistoryOfPayments",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GenderCategoryID",
                table: "GenderCategory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CreditCardID",
                table: "CreditCard",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CouponID",
                table: "Coupon",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CheckID",
                table: "Check",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BrandCategoryID",
                table: "BrandCategory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "BranchID",
                table: "Branch",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Warehouse",
                table: "Warehouse",
                column: "WarehouseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategory",
                table: "SubCategory",
                column: "SubCategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "SizeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "ShoppingCartID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchase",
                table: "Purchase",
                column: "PurchaseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "PaymentMethodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemSize",
                table: "ItemSize",
                column: "ItemSizeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCostHistory",
                table: "ItemCostHistory",
                column: "ItemCostHistoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "InventoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoryOfPayments",
                table: "HistoryOfPayments",
                column: "HistoryOfPaymentsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GenderCategory",
                table: "GenderCategory",
                column: "GenderCategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CreditCard",
                table: "CreditCard",
                column: "CreditCardID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon",
                column: "CouponID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Check",
                table: "Check",
                column: "CheckID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BrandCategory",
                table: "BrandCategory",
                column: "BrandCategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_GenderCategoryID",
                table: "Item",
                column: "GenderCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SubCategoryID",
                table: "Item",
                column: "SubCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_City_CityId",
                table: "Branch",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Check_Coupon_CouponID",
                table: "Check",
                column: "CouponID",
                principalTable: "Coupon",
                principalColumn: "CouponID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Check_PaymentMethod_PaymentMethodID",
                table: "Check",
                column: "PaymentMethodID",
                principalTable: "PaymentMethod",
                principalColumn: "PaymentMethodID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryOfPayments_Check_CheckID",
                table: "HistoryOfPayments",
                column: "CheckID",
                principalTable: "Check",
                principalColumn: "CheckID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Branch_BranchID",
                table: "Inventory",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_ItemSize_ItemSizeID",
                table: "Inventory",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ItemSizeID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_BrandCategory_BrandCategoryID",
                table: "Item",
                column: "BrandCategoryID",
                principalTable: "BrandCategory",
                principalColumn: "BrandCategoryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_GenderCategory_GenderCategoryID",
                table: "Item",
                column: "GenderCategoryID",
                principalTable: "GenderCategory",
                principalColumn: "GenderCategoryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_SubCategory_SubCategoryID",
                table: "Item",
                column: "SubCategoryID",
                principalTable: "SubCategory",
                principalColumn: "SubCategoryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemCostHistory_Item_ItemID",
                table: "ItemCostHistory",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSize_Item_ItemID",
                table: "ItemSize",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemSize_Size_SizeID",
                table: "ItemSize",
                column: "SizeID",
                principalTable: "Size",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ItemSize_ItemSizeID",
                table: "Order",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ItemSizeID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ShoppingCart_ShoppingCartID",
                table: "Order",
                column: "ShoppingCartID",
                principalTable: "ShoppingCart",
                principalColumn: "ShoppingCartID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Branch_BranchID",
                table: "Purchase",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_ItemSize_ItemSizeID",
                table: "Purchase",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ItemSizeID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Branch_BranchID",
                table: "ShoppingCart",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_Check_CheckID",
                table: "ShoppingCart",
                column: "CheckID",
                principalTable: "Check",
                principalColumn: "CheckID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_CreditCard_CreditCardID",
                table: "ShoppingCart",
                column: "CreditCardID",
                principalTable: "CreditCard",
                principalColumn: "CreditCardID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategory_Category_CategoryID",
                table: "SubCategory",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_Branch_BranchID",
                table: "Warehouse",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Warehouse_ItemSize_ItemSizeID",
                table: "Warehouse",
                column: "ItemSizeID",
                principalTable: "ItemSize",
                principalColumn: "ItemSizeID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
