using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetworkManagmentAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class IsProcessed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProcessed",
                table: "DistributorSells",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsProcessed", "SellDate" },
                values: new object[] { false, new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsProcessed", "SellDate" },
                values: new object[] { false, new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsProcessed", "SellDate" },
                values: new object[] { false, new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "DistributorSells",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsProcessed", "SellDate" },
                values: new object[] { false, new DateTime(2023, 12, 29, 22, 45, 24, 828, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "2fb3504a-433a-4890-9aa5-4f2a577e1416");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "53eac4c6-fe06-4039-8ed8-fbd7bd4dbc15");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "36057f25-ff58-4a3b-9736-f3beee1d7eca");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Code",
                value: "59ccede5-befd-4460-b56b-a5e12cbf5340");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProcessed",
                table: "DistributorSells");

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
        }
    }
}
