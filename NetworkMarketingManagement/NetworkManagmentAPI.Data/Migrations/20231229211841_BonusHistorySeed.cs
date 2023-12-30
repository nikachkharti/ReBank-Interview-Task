using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class BonusHistorySeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BonusHistories",
                columns: new[] { "Id", "BonusAmount", "DateCalculated", "DistributorId", "SaleId" },
                values: new object[,]
                {
                    { 1, 154.90m, new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1540), 1, 1 },
                    { 2, 434.70m, new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1543), 2, 2 },
                    { 3, 144.90m, new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1545), 2, 3 },
                    { 4, 500m, new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1546), 3, 4 }
                });

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 18, 41, 205, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "bd23cacc-585f-49cc-b9de-0fcaf162e016");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "8476553a-8200-4220-abd2-72ee50498646");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "ebd35711-e8d6-410e-93bb-0375f8651e19");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "f048774d-a0cd-46b4-b12a-b6fd317ba020");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BonusHistories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BonusHistories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BonusHistories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BonusHistories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 3, 29, 336, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 3, 29, 336, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 3, 29, 336, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 1, 3, 29, 336, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "7d5ad072-2b6d-47f2-94fb-4561587c4722");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "932919ee-6e3f-4383-a84e-d26b355720ea");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "6c899d12-58c4-4a1d-b72a-dccbfad03d73");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "fef2b186-e39d-4095-ad49-1d668a860de7");
        }
    }
}
