using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class SubRecomendationsCountMaxValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 26, 15, 50, 15, 812, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 26, 15, 50, 15, 812, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 26, 15, 50, 15, 812, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 26, 15, 50, 15, 812, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "37483773-8a9d-448a-bb28-9ea72a069a47");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "4c3a01e7-a9e1-451c-bb67-14562fda1769");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "b1ca95c6-8ffb-46e0-9de3-8a2364c56eee");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "eaf41cf3-4824-4810-b650-87f5855a08f1");
        }
    }
}
