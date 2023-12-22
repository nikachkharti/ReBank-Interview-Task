using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DistributorSells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistributorId = table.Column<int>(type: "int", nullable: false),
                    SellDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellsCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistributorSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DistributorSells_Distributors_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DistributorSells_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Code", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "cb58a2d8-47dd-452f-b7f3-f0343d14d431", 1549m, "Iphone 12" },
                    { 2, "c5290d5a-77ff-4499-9975-ac8444b0375f", 1449m, "Iphone 11" },
                    { 3, "1434be4d-9978-4305-98bc-d925c1561531", 1349m, "Iphone X" },
                    { 4, "5cb5caa3-2097-4cf3-8210-0bbe3996ce74", 2500m, "PS5" }
                });

            migrationBuilder.InsertData(
                table: "DistributorSells",
                columns: new[] { "Id", "DistributorId", "ProductId", "SellDate", "SellsCount", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4969), 1, 1549m },
                    { 2, 2, 2, new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4978), 3, 4347m },
                    { 3, 2, 3, new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4980), 1, 1449m },
                    { 4, 3, 3, new DateTime(2023, 12, 22, 17, 28, 15, 779, DateTimeKind.Local).AddTicks(4981), 2, 5000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistributorSells_DistributorId",
                table: "DistributorSells",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_DistributorSells_ProductId",
                table: "DistributorSells",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Code",
                table: "Products",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistributorSells");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
