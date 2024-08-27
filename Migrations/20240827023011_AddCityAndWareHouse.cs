using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreTask.Ibrahimahmed.Migrations
{
    /// <inheritdoc />
    public partial class AddCityAndWareHouse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeliveryZone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeliveryCost = table.Column<float>(type: "real", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    WarehouseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WareHouseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.WarehouseID);
                });

            migrationBuilder.CreateTable(
                name: "CityWareHouse",
                columns: table => new
                {
                    CitiesCityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WareHousesWarehouseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityWareHouse", x => new { x.CitiesCityID, x.WareHousesWarehouseID });
                    table.ForeignKey(
                        name: "FK_CityWareHouse_Cities_CitiesCityID",
                        column: x => x.CitiesCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityWareHouse_WareHouses_WareHousesWarehouseID",
                        column: x => x.WareHousesWarehouseID,
                        principalTable: "WareHouses",
                        principalColumn: "WarehouseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityWareHouse_WareHousesWarehouseID",
                table: "CityWareHouse",
                column: "WareHousesWarehouseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityWareHouse");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "WareHouses");
        }
    }
}
