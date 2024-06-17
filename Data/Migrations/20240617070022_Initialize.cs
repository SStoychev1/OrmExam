using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "shipings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SalesChanel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_shipings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitSold = table.Column<int>(type: "int", nullable: false),
                    UnitCost = table.Column<double>(type: "float", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrederId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderPriority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shipingId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_shipings_shipingId",
                        column: x => x.shipingId,
                        principalTable: "shipings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemInfos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemInfos_Units_Id",
                        column: x => x.Id,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "totals",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalRevenue = table.Column<double>(type: "float", nullable: false),
                    TotalCosts = table.Column<double>(type: "float", nullable: false),
                    TotalProfit = table.Column<double>(type: "float", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_totals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_totals_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_shipingId",
                table: "orders",
                column: "shipingId");

            migrationBuilder.CreateIndex(
                name: "IX_totals_OrderId",
                table: "totals",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemInfos");

            migrationBuilder.DropTable(
                name: "totals");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "shipings");
        }
    }
}
