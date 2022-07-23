using Microsoft.EntityFrameworkCore.Migrations;

namespace CCAP_Inventory_Management.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OutGoings",
                columns: table => new
                {
                    OutGoingProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutGoingProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutGoingQuantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutGoingSupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutGoingLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutGoingCategory = table.Column<int>(type: "int", nullable: false),
                    OutGoingStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutGoings", x => x.OutGoingProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutGoings");
        }
    }
}
