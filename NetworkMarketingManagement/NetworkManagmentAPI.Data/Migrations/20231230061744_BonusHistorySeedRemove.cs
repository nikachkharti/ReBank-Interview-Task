using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class BonusHistorySeedRemove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2023, 12, 30, 10, 17, 44, 617, DateTimeKind.Local).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 10, 17, 44, 617, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 10, 17, 44, 617, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 30, 10, 17, 44, 617, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "6082bc05-2a93-46bc-832c-f91c98a16728");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "ce9d4d5e-459c-465b-b050-c00a52d48aa1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "361bbc76-36e5-48d0-8203-2407b9b593c9");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "40c066c4-4928-4fe6-b0b4-240e4dda0e03");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
