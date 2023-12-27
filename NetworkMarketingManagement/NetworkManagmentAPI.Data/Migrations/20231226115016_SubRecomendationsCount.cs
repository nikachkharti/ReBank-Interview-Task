using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class SubRecomendationsCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubRecomendationsCount",
                table: "Distributors",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubRecomendationsCount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubRecomendationsCount",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Distributors",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubRecomendationsCount",
                value: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubRecomendationsCount",
                table: "Distributors");

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                column: "SellDate",
                value: new DateTime(2023, 12, 24, 21, 49, 13, 293, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "3e2004e7-ddfb-4634-8f5a-10418588be41");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "d65141d4-fa67-49e6-b41e-21103490e27b");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "6848964f-b790-4129-bfe2-b001e6f8ebb7");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "c3210dd9-fee5-4703-bbfd-3333cf7a6514");
        }
    }
}
