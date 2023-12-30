using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class BonusHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Code",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "BonusHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistributorId = table.Column<int>(type: "int", nullable: false),
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    BonusAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCalculated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BonusHistories_DistributorSells_SaleId",
                        column: x => x.SaleId,
                        principalTable: "DistributorSells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BonusHistories_Distributors_DistributorId",
                        column: x => x.DistributorId,
                        principalTable: "Distributors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 42, 12, 416, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 42, 12, 416, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 42, 12, 416, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 29, 22, 42, 12, 416, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "1715edbe-670c-4bc9-b8b8-0915827cfa5a");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "bb50c14d-3905-4e97-b748-59e5b598f441");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "940f8d9b-c773-4dc7-b9ec-0ef9d9a6d77e");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "82442881-b9b0-48b2-89b2-dcc29a5ff122");

            migrationBuilder.CreateIndex(
                name: "IX_BonusHistories_DistributorId",
                table: "BonusHistories",
                column: "DistributorId");

            migrationBuilder.CreateIndex(
                name: "IX_BonusHistories_SaleId",
                table: "BonusHistories",
                column: "SaleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BonusHistories");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Products",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 27, 15, 48, 7, 190, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 27, 15, 48, 7, 190, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 27, 15, 48, 7, 190, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 27, 15, 48, 7, 190, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "62af99d6-0447-4862-8caf-53fbb34f8b2b");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "92c18649-1027-45d1-8b29-e9848ea38cb9");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "a09e0285-33d4-4e1a-b1e7-5698c56c0491");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "212d7c1f-f5de-47d8-8819-4d7aa297c38e");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Code",
                table: "Products",
                column: "Code",
                unique: true);
        }
    }
}
